using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;

namespace Calculator
{

    //definitions



    /// <summary>
    /// An enum for choosing angle units for trigonometric functions. 
    /// <br/><br/><example>For example: Rad for Radian, Deg for Degree, and Grad for Gradian.)</example>
    /// </summary>
    public enum AngleUnit
    {
        Rad,
        Deg,
        Grad
    };

    /// <summary>
    /// The type (object type) of the Token.
    /// </summary>
    public enum TokenType
    {
        NUMBER,
        SPECIAL,
        IDENTIFIER,
        ADDITION,
        SUBTRACTION,
        MULTIPLICATION_DIVISION,
        EXPONENTIATION,
        PARENTHESIS_LEFT,
        PARENTHESIS_RIGHT
    };

    /// <summary>
    /// The Token Types to find in Regex.
    /// </summary>
    public class TokenSpec
    {
        /// <summary>
        /// The List of specs for this (readonly).
        /// </summary>
        public static readonly List<(Regex, TokenType?)> Specs = new List<(Regex, TokenType?)>
        {
            (new Regex(@"^\s+"), null),
            (new Regex(@"^(?:\d+(?:\.\d*)?|\.\d+)\%?"), TokenType.NUMBER),
            (new Regex(@"^(pi|π|𝑒)", RegexOptions.IgnoreCase), TokenType.SPECIAL),
            (new Regex(@"^(?!pi|π|yroot|mod)^[a-z]+", RegexOptions.IgnoreCase), TokenType.IDENTIFIER),
            (new Regex(@"^\+"), TokenType.ADDITION),
            (new Regex(@"^\-"), TokenType.SUBTRACTION),
            (new Regex(@"^(\*|\/|mod)"), TokenType.MULTIPLICATION_DIVISION),
            (new Regex(@"^(\^|yroot)", RegexOptions.IgnoreCase), TokenType.EXPONENTIATION),
            (new Regex(@"^\("), TokenType.PARENTHESIS_LEFT),
            (new Regex(@"^\)"), TokenType.PARENTHESIS_RIGHT)
        };
    };

    /// <summary>
    /// The token to handle.
    /// </summary>
    public class Token
    {
        public TokenType Type { get; set; }
        public string Value { get; set; }
    };






    //stuffs to handle

    /// <summary>
    /// The Tokenizer system for handling specific token.
    /// </summary>
    public class Tokenizer
    {
        private string input;
        private int cursor;

        public Tokenizer(string input)
        {
            this.input = input;
            this.cursor = 0;
        }

        private string Match(Regex regex, string inputSlice)
        {
            var match = regex.Match(inputSlice);
            if (!match.Success)
            {
                return null;
            }

            cursor += match.Length;
            return match.Value;
        }

        public Token GetNextToken()
        {
            if (!(cursor < input.Length))
            {
                return null;
            }

            string inputSlice = input.Substring(cursor);

            foreach (var (regex, type) in TokenSpec.Specs)
            {
                string tokenValue = Match(regex, inputSlice);

                if (tokenValue == null)
                {
                    continue;
                }

                if (type == null)
                {
                    return GetNextToken();
                }

                if (type == TokenType.NUMBER && tokenValue.EndsWith("%"))
                {
                    tokenValue=(double.Parse(tokenValue.Replace("%", ""))/100).ToString();
                }


                return new Token
                {
                    Type = type.Value,
                    Value = tokenValue
                };
            }

            throw new FormatException($"Unexpected token: \"{inputSlice[0]}\"");
        }
    };


    //Parser

    /// <summary>
    /// The MathParser class.
    /// </summary>
    public class MathParser
    {

        private readonly string[] TokenTypeString = new string[] {
        "Number",
        "PI",
        "A proper function",
        "Addition",
        "Subtraction",
        "Multiplication or Division",
        "Exponentation",
        "(",
        ")"
        };//only used by error output.

        #region The long Documentation.
        /// <summary>
        /// The Angle Unit to set. (Default: Rad)
        /// </summary>
        public AngleUnit angleUnit;
        private Tokenizer tokenizer;
        private Token lookahead;

        /// <summary>
        /// The Parse function of the parser that calculates your calculation.
        /// <br /><br />
        /// <example>
        /// For example:<code>
        /// <see cref="new">new</see> <see cref="MathParser">MathParser</see>.<see cref="Parse(string)">Parse</see>("1+2*3+((6+6)*3/5)");
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="input">This is where the calculation is put in.</param>
        /// <returns>A <see cref="double">double</see>-type value of the result. Like the result from the example above, <c>14.2</c>.</returns>
        /// <exception cref="ArgumentException">Throws an ArgumentException if your <paramref name="input">input</paramref> string is empty</exception>
        /// <exception cref="FormatException"></exception>
        #endregion
        public double Parse(string input)
        {
            if (angleUnit==null) this.angleUnit = AngleUnit.Rad;
            if (input == "") throw new ArgumentException("There's an empty input.");
            this.tokenizer = new Tokenizer(input);
            this.lookahead = this.tokenizer.GetNextToken();

            return Expression();
        }

        private Token Eat(TokenType tokenType)
        {
            //Token token = this.lookahead; if(token==null) throw new FormatException($"Unexpected end of input, {this.TokenTypeString[(int)tokenType]} expected.");
            //VS refactored to
            Token token = this.lookahead ?? throw new FormatException($"Unexpected end of input, {this.TokenTypeString[(int)tokenType]} expected.");
            if (token.Type != tokenType)
            {
                throw new FormatException($"Unexpected token: \"{token.Value}\", {this.TokenTypeString[(int)tokenType]} expected.");
            }

            this.lookahead = this.tokenizer.GetNextToken();

            return token;
        }

        private double BinaryExpression(Func<double> leftRule, Func<double> rightRule, TokenType operatorType1, TokenType? operatorType2 = null)
        {
            double left = leftRule();
            while (this.lookahead != null && (this.lookahead.Type == operatorType1 || (operatorType2.HasValue && this.lookahead.Type == operatorType2)))
            {
                Token Operator = Eat(this.lookahead.Type);
                TokenType operatorType = Operator.Type;
                if (double.IsNaN(left)) return left;
                switch (operatorType)
                {
                    case TokenType.ADDITION:
                        left += rightRule();
                        break;
                    case TokenType.SUBTRACTION:
                        left -= rightRule();
                        break;
                    case TokenType.MULTIPLICATION_DIVISION:
                        switch (Operator.Value)
                        {
                            case "*":
                                left *= rightRule();
                                break;
                            case "/":
                                double right = rightRule();
                                if(right==0)return double.NaN;
                                left /= right;
                                break;
                            case "mod":
                                if (lookahead.Type == TokenType.NUMBER) left %= rightRule();
                                else if (lookahead.Type == TokenType.PARENTHESIS_LEFT) left %= ParenthesizedExpression();
                                break;
                        }
                        break;
                    case TokenType.EXPONENTIATION:
                        switch (Operator.Value)
                        {

                            case "^":
                                if (lookahead.Type == TokenType.NUMBER) left = Math.Pow(left, double.Parse(Eat(this.lookahead.Type).Value));
                                else left = Math.Pow(left, ParenthesizedExpression());
                                break;
                            case "yroot":
                                if (left == 0) left = double.NaN;
                                else if (lookahead.Type == TokenType.NUMBER) left = Math.Pow(double.Parse(Eat(this.lookahead.Type).Value), 1 / left);
                                else if (lookahead.Type == TokenType.PARENTHESIS_LEFT) left = Math.Pow(ParenthesizedExpression(), 1 / left);
                                break;
                        }
                        break;
                }

                if (double.IsInfinity(left) && double.IsNaN(left)) left = double.NaN;
            }

            return left;
        }

        private double Expression()
        {
            return BinaryExpression(Term, Term, TokenType.ADDITION, TokenType.SUBTRACTION);
        }

        private double Term()
        {
            return BinaryExpression(Factor, Factor, TokenType.MULTIPLICATION_DIVISION);
        }

        private double Factor()
        {
            return BinaryExpression(Primary, Factor, TokenType.EXPONENTIATION);
        }

        private double Primary()
        {
            if (this.lookahead.Type == TokenType.PARENTHESIS_LEFT)
            {
                return ParenthesizedExpression();
            }
            else if (this.lookahead.Type == TokenType.SUBTRACTION)
            {
                //UnaryExpression
                Eat(TokenType.SUBTRACTION);
                return -Factor();
            }
            else if (this.lookahead.Type == TokenType.IDENTIFIER)
            {
                return FunctionExpression();
            }
            else if (this.lookahead.Type == TokenType.SPECIAL)
            {
                Token token = Eat(TokenType.SPECIAL);
                return double.Parse(Regex.Replace(token.Value, "(pi|π)", Math.PI.ToString(), RegexOptions.IgnoreCase).Replace("𝑒", Math.E.ToString()));
            }
            else
            {
                Token token = Eat(TokenType.NUMBER);
                return double.Parse(token.Value);
            }
        }

        private double ParenthesizedExpression()
        {
            Eat(TokenType.PARENTHESIS_LEFT);
            double expression = Expression();
            Eat(TokenType.PARENTHESIS_RIGHT);

            return expression;
        }

        private double FunctionExpression()
        {
            string id = Eat(TokenType.IDENTIFIER).Value;
            if(id=="logbase")
            {
                double Base, n;
                Base = Primary();//Primary 1
                n = ParenthesizedExpression();//expression
                
                return Math.Log(n, Base);
            }
            double value = ParenthesizedExpression();
            double converted_value, second_value;

            if (angleUnit == AngleUnit.Deg) converted_value = value * (Math.PI / 180);
            else if (angleUnit == AngleUnit.Grad) converted_value = value * (Math.PI / 200);
            else converted_value = value;

            switch (id)
            {
                #region Trigonometric Functions
                case "sin":
                    return Math.Sin(converted_value);
                case "cos":
                    return -Math.Sin(converted_value-(Math.PI/2));//becoz else math.cos is the alternative an it kills you for the wrong'd result (math.sin(x-(math.PI/2) results not 0 at 90 deg but an irrational))
                case "tan":
                    if (converted_value % Math.PI == Math.PI / 2) return double.NaN;
                    return Math.Tan(converted_value);
                case "csc":
                    second_value = Math.Sin(converted_value);
                    if (second_value == 0)
                        return double.NaN;
                    return 1 / second_value;
                case "sec":
                    second_value = -Math.Sin(converted_value-(Math.PI/2));;
                    if (second_value == 0)
                        return double.NaN;
                    return 1 / second_value;
                case "cot":
                    second_value = Math.Sin(converted_value);
                    if (second_value == 0)
                        return double.NaN;

                    return -Math.Sin(converted_value - (Math.PI / 2)) / second_value;
                //cosx/sinx=cotx
                #endregion

                #region Hyperbolic Trigonometric Functions
                case "sinh":
                    return double.IsInfinity(Math.Sinh(value)) ? double.NaN : Math.Sinh(value);
                case "cosh":
                    return double.IsInfinity(Math.Cosh(value)) ? double.NaN : Math.Cosh(value);
                case "tanh":
                    return Math.Tanh(value);
                case "csch":
                    second_value = Math.Sinh(value);
                    if (second_value == 0)
                        return double.NaN;

                    return 1 / second_value;
                case "sech":
                    second_value = Math.Cosh(value);
                    return 1 / second_value;
                case "coth":
                    if (value == 0)
                        return double.NaN;

                    return 1 / Math.Tanh(value);
                #endregion

                #region Inverse Trigonometric Functions
                case "asin":
                    if (Math.Abs(value) > 1) return double.NaN;
                    if (angleUnit == AngleUnit.Deg) return Math.Asin(value) * (180 / Math.PI);
                    else if (angleUnit == AngleUnit.Grad) return Math.Asin(value) * (200 / Math.PI);
                    else return Math.Asin(value);
                case "acos":
                    if (Math.Abs(value) > 1) return double.NaN;
                    if (angleUnit == AngleUnit.Deg) return Math.Acos(value) * (180 / Math.PI);
                    else if (angleUnit == AngleUnit.Grad) return Math.Acos(value) * (200 / Math.PI);
                    else return Math.Acos(value);
                case "atan":
                    if (angleUnit == AngleUnit.Deg) return Math.Atan(value) * (180 / Math.PI);
                    else if (angleUnit == AngleUnit.Grad) return Math.Atan(value) * (200 / Math.PI);
                    else return Math.Atan(value);
                case "acsc":
                    if (!(Math.Abs(value) >= 1)) return double.NaN;
                    if (angleUnit == AngleUnit.Deg) return Math.Asin(1 / value) * (180 / Math.PI);
                    else if (angleUnit == AngleUnit.Grad) return Math.Asin(1 / value) * (200 / Math.PI);
                    else return Math.Asin(1 / value);
                case "asec":
                    if (!(Math.Abs(value) >= 1)) return double.NaN;
                    if (angleUnit == AngleUnit.Deg) return Math.Acos(1 / value) * (180 / Math.PI);
                    else if (angleUnit == AngleUnit.Grad) return Math.Acos(1 / value) * (200 / Math.PI);
                    else return Math.Acos(1 / value);
                case "acot":
                    if (value == 0) return double.NaN;
                    if (angleUnit == AngleUnit.Deg) return Math.Atan(1 / value) * (180 / Math.PI);
                    else if (angleUnit == AngleUnit.Grad) return Math.Atan(1 / value) * (200 / Math.PI);
                    else return Math.Atan(1 / value);

                #region Inverse Hyperbolic Trigonometric Functions
                case "asinh":
                    if (value < 0) return -Math.Log(-value + Math.Sqrt(value * value + 1));
                    return Math.Log(value + Math.Sqrt(value * value + 1));
                case "acosh":
                    if (value < 1) return double.NaN;
                    return Math.Log(value + Math.Sqrt(value * value - 1));
                case "atanh":
                    if (Math.Abs(value) >= 1) return double.NaN;
                    return Math.Log((1 + value) / (1 - value)) / 2;
                case "acsch":
                    if (value == 0) return double.NaN;
                    if (value < 0) return -Math.Log(1 / -value + Math.Sqrt(1 / (value * value) + 1));
                    return Math.Log(1 / value + Math.Sqrt(1 / (value * value) + 1));
                case "asech":
                    if (value <= 0 || value > 1) return double.NaN;
                    return Math.Log(1 / value + Math.Sqrt(1 / (value * value) - 1));
                case "acoth":
                    if (Math.Abs(value) <= 1) return double.NaN;
                    return Math.Log((value + 1) / (value - 1)) / 2;
                #endregion Inverse Hyperbolic Trigonometric Functions

                #endregion Inverse Trigonometric Functions

                #region Everything Else
                case "sqrt":
                    if(value<0)return double.NaN;
                    return Math.Sqrt(value);
                case "cbrt":
                    return Math.Pow(value, (1 / 3));
                case "sqr":
                    return Math.Pow(value, 2);
                case "cube":
                    return Math.Pow(value, 3);
                case "abs":
                    return Math.Abs(value);
                case "round":
                    return Math.Round(value);
                case "floor":
                    return Math.Floor(value);
                case "ceil":
                    return Math.Ceiling(value);
                case "fact":
                    return Math.Round(value) == value ? Math.Round(Gamma(value)) : Gamma(value);
                case "exp":
                    return value;
                case "ln":
                    return Math.Log(value);
                case "log":
                    return Math.Log10(value);
                #endregion

                default:
                    return double.NaN;
            }
        }

        #region Gamma and Factorial
        //Gamma/Factorial based on: https://en.wikipedia.org/wiki/Lanczos_approximation

        private static readonly int g = 7;
        private static readonly double[] p =
        {
            0.99999999999980993,
            676.5203681218851,
            -1259.1392167224028,
            771.32342877765313,
            -176.61502916214059,
            12.507343278686905,
            -0.13857109526572012,
            9.9843695780195716e-6,
            1.5056327351493116e-7
        };
        private static double Gamma(double z)
        {
            if (z < 0.5)
                return Math.PI / (Math.Sin(Math.PI * z) * Gamma(1 - z));

            double x = p[0];
            for (var i = 1; i < g + 2; i++)
                x += p[i] / (z + i);
            double t = z + g + 0.5;
            return Math.Sqrt(2 * Math.PI) * (Math.Pow(t, z + 0.5)) * Math.Exp(-t) * x;
        }
        #endregion
    }
}
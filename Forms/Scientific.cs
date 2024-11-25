using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Win32;
using System.Linq;
using System.Security.Policy;




namespace Calculator
{
    public partial class Scientific : Form
    {
        public string first_num, to_calculate, operation,
                      decimal_seprator, icons, last_memory;
        public bool MemoriesPanel_enabled, number_is_written, equal_pressed, operation_pressed, special_sepator_trigger, 
            
            second_button_on, extended_2nd_button_on, hyperbol_button_on;
        public int ExtendedPanel_height, counter, brackets, length_to_erase;
        public Button lastbutton, CurrentExtendedButton;
        public MathParser parser;
        public Panel extended_panel;
        public Scientific()
        {
            this.MemoriesPanel_enabled = false;
            this.operation_pressed = false;
            first_num = "0";
            this.decimal_seprator =
                CultureInfo.CurrentUICulture.NumberFormat.
                            NumberDecimalSeparator.ToString();
            parser = new MathParser()
            {
                angleUnit = AngleUnit.Rad
            };

            InitializeComponent();

            //doublebuffer
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer|ControlStyles.AllPaintingInWmPaint|ControlStyles.UserPaint, true);

            RegistryKey reg = Registry.LocalMachine.
            OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            



            string build_version = reg.GetValue("CurrentBuild") as string;
            icons = int.Parse(build_version) >= 22000 ?
            "Segoe Fluent Icons" : "Segoe MDL2 Assets";
            
            this.DelButton.Font = new System.Drawing.Font(this.icons,
                13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            
            this.menuButton.Font = new System.Drawing.Font(this.icons,
                10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton1.Font = new System.Drawing.Font(this.icons,
                13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton2.Font = this.menuButton1.Font;
            

            this.MemButton1.ForeColor = SystemColors.GrayText;
            this.MemButton2.ForeColor = SystemColors.GrayText;
            this.MemButton6.ForeColor = SystemColors.GrayText;

            this.ExtendedPanel_height = Convert.ToInt32(DeviceDpi*1.125);
            foreach (Control item in ExtendedPanel1.Controls) {
                item.Height = Convert.ToInt32(DeviceDpi / 2.1);
            }
            foreach (Control item in ExtendedPanel2.Controls)
            {
                item.Height = Convert.ToInt32(DeviceDpi / 2.1);
            }
            this.MemPanel.Width = this.Width;

            Utils.FontScale(this.Controls, 1);
            
            this.ExtendedPanel_height = Convert.ToInt32(ExtendedPanel_height);

            this.numBox.Text = parser.Parse("2yroot((acosh(1)+13)mod3^1-2*2/(4/2*2)+9)-3+(1/3*3)-1").ToString();
            this.CurrentExtendedButton = ExtendedButton1;

        }
        private void ChangeOperationButtonsForeColor(Color color)
        {
            Button[] buttons = new Button[] {
                this.percentButton, this.InverseButton, this.sqrtButton, this.sqrButton,
                this.divideButton, this.multiplyButton, this.minusButton, this.addButton,
                this.PlusMinusButton, this.decimalButton, this.decimalButton, this.equalButton,
                this.MemButton3, this.MemButton4, this.MemButton5
            };
            foreach (Button button in buttons)
            {
                button.ForeColor = color;
            }
            foreach (Button button in this.MemPanel.Controls)
            {
                button.Controls[1].ForeColor = color;
                button.Controls[2].ForeColor = color;
            }
        }


        private void NumButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            if (this.first_num.EndsWith("^2") || this.first_num.EndsWith(")")) return;
            if (this.first_num.EndsWith("𝑒") || this.first_num.EndsWith("π"))
            {
                this.to_calculate+=this.first_num+ "×";
                this.first_num = "0";
                this.calculationBox.Text= this.to_calculate;
            }
            if (this.numBox.Text == "Fehler")
            {
                this.calculationBox.Text = to_calculate;
                this.numBox.Text = first_num;
                ChangeOperationButtonsForeColor(System.Drawing.SystemColors.ControlText);
            }
            if (this.equal_pressed)
            {
                equal_pressed = false;
                ClearButton.PerformClick();
            } 

            if (this.operation != "" && (this.to_calculate == "0" || this.to_calculate == ""))
            {
                this.to_calculate = this.first_num.Replace(decimal_seprator, "");
                this.first_num = this.special_sepator_trigger ? this.first_num : "0";
            }

            Button NumButton = sender as Button;
            
            if (this.first_num == "0" || this.operation_pressed || this.special_sepator_trigger)
            {
                bool reply_to_this_thing = Regex.Match(numBox.Text, "[.,]").Success;
                if (NumButton.Text == "0") this.first_num = (this.special_sepator_trigger ||
                        reply_to_this_thing ? this.numBox.Text : "") + NumButton.Text;
                else this.first_num = (this.special_sepator_trigger ?
                        this.numBox.Text : "") + NumButton.Text;
                this.operation_pressed = false;
                this.special_sepator_trigger = false;
                if (lastbutton != null) lastbutton.BackColor = SystemColors.ControlLight;
            }
            else this.first_num += NumButton.Text;
            this.numBox.Text = this.first_num;

            if ((this.to_calculate + "").EndsWith(")"))
            {
                this.to_calculate += "×";
                this.calculationBox.Text = this.to_calculate;
            }


            this.number_is_written = true;
        }


        private void DecimalSepratorButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            if (this.numBox.Text == "Fehler") return;

            
            Match match = Regex.Match(this.first_num, "[,.]", RegexOptions.None, TimeSpan.FromSeconds(1));
            if (!this.operation_pressed)
            {
                if (match.Success) return;
                this.first_num += decimal_seprator;
                this.numBox.Text = this.first_num;
            }
            else
            {
                this.first_num = "0" + decimal_seprator;
                this.numBox.Text = this.first_num;
                this.operation_pressed = false;
                this.special_sepator_trigger = true;
            }

            this.number_is_written = true;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.numBox.Text == "Fehler") ChangeOperationButtonsForeColor(SystemColors.ControlText);

            Button OperationButton = sender as Button;
            switch (OperationButton.Text)
            {
                case "CE":
                    
                        this.length_to_erase = 1;
                    if (this.equal_pressed)
                    {
                        this.ClearButton.PerformClick();
                        return;
                    }
                    this.first_num = "0";
                    this.calculationBox.Text = to_calculate;
                    break;
                case "C":
                    this.first_num = "0";
                    this.to_calculate = "";
                    this.operation = "";
                    this.operation_pressed = false;
                    this.calculationBox.Text = "";
                    this.brackets = 0;
                    this.bracketOpen.Text = "(";
                    if (lastbutton != null) lastbutton.BackColor = SystemColors.ControlLight;
                    break;
                case "":
                    if (this.operation_pressed) {
                        this.ClearEntryButton.PerformClick();
                        return; 
                    }
                    if (this.equal_pressed)
                    {
                        ClearButton.PerformClick();
                        this.calculationBox.Text = "";
                        return;
                    }
                    if (Regex.Match(this.first_num, "E[0-9]*").Success)
                    {
                        this.first_num = Regex.Replace(this.first_num, "E.[0-9]*", "");
                        break;
                    }
                    this.first_num = this.first_num.Length == 1 ?
                        "0" :
                        this.first_num.Remove(first_num.Length - length_to_erase, length_to_erase);
                    length_to_erase = 1;
                    break;
            }
            this.numBox.Text = this.first_num;
            this.equal_pressed = false;
            this.number_is_written = false;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            if (this.numBox.Text == "Fehler") return;

            first_num += ((
                Regex.Match(this.first_num, @"(\d|𝑒|π)*([,.](?!(\d|𝑒|π)))", RegexOptions.None, TimeSpan.FromSeconds(1)).Success
                ) ? "0" : "");
            Button OperationButton = sender as Button;
            
            if (this.operation_pressed)
            {

                
                this.to_calculate = this.to_calculate.Remove(this.to_calculate.Length - operation.Length);
                lastbutton = null;

                OperationButton.BackColor = SystemColors.ControlLight;


                if (this.operation == OperationButton.Text)
                {
                    this.operation_pressed = false;
                }
                else
                {
                    this.operation = OperationButton.Text;
                    this.to_calculate += operation.Replace("ʸ√", "yroot").Replace("xʸ", "^").Replace("10ˣ", "10^").Replace("2ˣ", "2^");
                }

                this.calculationBox.Text = to_calculate;
                this.numBox.Text = first_num;
            }
            else
            {
                
                
                
                

                this.operation = OperationButton.Text;
                this.to_calculate += (Regex.Match("" + this.to_calculate, @"(\d|𝑒|π|\))$").Success ? "" : this.first_num) 
                    + operation.Replace("ʸ√", "yroot").Replace("xʸ", "^").Replace("10ˣ", "×10^").Replace("2ˣ", "×2^");

                this.calculationBox.Text = to_calculate;
                this.numBox.Text = first_num;
                this.operation_pressed = true;
            }


            this.equal_pressed = false;
        }
        private void SpecialNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (this.numBox.Text == "Fehler")
            {
                this.first_num = button.Text=="e" ? "𝑒": "π";
            } else if(!Regex.Match("" + this.to_calculate, @"(\d|𝑒|π|\(|\)|×|÷|\+|\-)$").Success&&
                Regex.Match("" + this.first_num, @"(\d|𝑒|π)$").Success && this.first_num!="0"||
                (!this.number_is_written&&this.operation_pressed))
            {
                this.to_calculate += this.first_num+"×";
                this.first_num=button.Text.Replace("e", "𝑒");
            } else
            {
                this.first_num = button.Text.Replace("e", "𝑒");
            }
            this.numBox.Text = this.first_num;
            this.calculationBox.Text = this.to_calculate;
        }
        private void SpecialOperation_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            if (this.numBox.Text == "Fehler") return;
            
            Button OperationButton = sender as Button;
            switch (OperationButton.Text)
            {
                case "%":
                    this.first_num += (this.first_num+"").EndsWith("%")?"":"%";
                    this.numBox.Text = this.first_num;
                    break;
                case "±":
                    this.first_num = (decimal.Parse(this.first_num) * -1).ToString();
                    this.numBox.Text = this.first_num;
                    break;
                case "𝑥²":
                    addCertainExponent("^2");
                    break;
                case "𝑥³":
                    addCertainExponent("^3");
                    break;
                case "√𝑥":
                    addCertainFunc("sqrt");
                    break;
                case "³√𝑥":
                    addCertainFunc("cbrt");
                    break;
                case "ln":
                    addCertainFunc("ln");
                    break;
                case "eʸ":
                    addCertainFunc("𝑒^");
                    break;
                case "log":
                    addCertainFunc("log");
                    break;
                case "𝑥⁻¹":
                    addCertainExponent("^(-1)");
                    break;
                case "logᵧ𝑥":
                    addCertainFunc("log");
                    this.bracketClose.Text += "(";
                    break;
                case "n!":
                    addCertainFunc("fact");
                    break;
            }

        }


        


        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            if (!equal_pressed&&!Regex.Match(this.to_calculate+"", @"(\d|\))$").Success) this.to_calculate += this.first_num;
            if(brackets>0)this.to_calculate += new String(')', this.brackets);
            this.calculationBox.Text = this.to_calculate+"=";
            this.first_num = (!double.IsNaN(parser.Parse(this.to_calculate.Replace("×", "*").Replace("÷", "/"))) ? parser.Parse(this.to_calculate.Replace("×", "*").Replace("÷", "/")) : double.NaN).ToString().Replace("NaN", "Fehler");
            this.numBox.Text = this.first_num;
            this.brackets = 0;
            this.bracketOpen.Text = "(";
            if (numBox.Text=="Fehler")
            {
                ChangeOperationButtonsForeColor(SystemColors.GrayText);
            }
            this.equal_pressed = true;
        }


        
        private void MemoryButton_Click(Object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.triggerMenu.Start();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            Button button = sender as Button;
            if (this.MemPanel.Controls.Count > 0) this.last_memory = this.MemPanel.Controls[0].Text;


            
            Button MemButton = new Button();
            MemButton.FlatAppearance.BorderSize = 0;
            MemButton.FlatStyle = FlatStyle.Flat;
            MemButton.Name = "Memorybutton" + (this.MemPanel.Controls.Count - 1).ToString();
            MemButton.Padding = new Padding(0, 2, Convert.ToInt32(DeviceDpi/10), 8);
            MemButton.TabIndex = this.MemPanel.Controls.Count;
            MemButton.Location = new Point(0, 0);
            MemButton.Size = new Size(Convert.ToInt32(this.MemPanel.Width - 8), Convert.ToInt32(this.MemPanel.Width/5));
            MemButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)0));
            MemButton.TextAlign = ContentAlignment.TopRight;
            
            MemButton.UseVisualStyleBackColor = true;
            MemButton.Click += new EventHandler(MemoryRecall_Click);
            
            

            for (int i = 2; i >= 0; i--)
            {
                string[] MemActionButton_Action = new string[] { "MC", "M+", "M-" };
                Button MemActionButton = new Button();
                MemActionButton.FlatAppearance.BorderSize = 0;
                MemActionButton.FlatStyle = FlatStyle.Flat;
                MemActionButton.Name = "Memorybutton" + (this.MemPanel.Controls.Count - 1).ToString() + "_Action_" + i.ToString();
                MemActionButton.TabIndex = MemButton.Controls.Count;
                MemActionButton.UseVisualStyleBackColor = true;
                MemActionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                MemActionButton.Size = new Size(Convert.ToInt32(DeviceDpi / 2.75), Convert.ToInt32(DeviceDpi / 3.75));
                MemActionButton.TextAlign = ContentAlignment.MiddleCenter;
                MemActionButton.Location = new Point(this.MemPanel.Width - Convert.ToInt32(i * DeviceDpi/2.25)-Convert.ToInt32(DeviceDpi*1.75/3), Convert.ToInt32(DeviceDpi/3.2));
                MemActionButton.Padding = new Padding(0);
                MemActionButton.Text = MemActionButton_Action[2-i];
                MemActionButton.Click += MemActionButton_Click;
                MemButton.Controls.Add(MemActionButton);
                
                

            }

            switch (button.Text)
            {
                case "MC":
                    this.last_memory = null;
                    this.MemPanel.Controls.Clear();
                    button.ForeColor = SystemColors.GrayText;
                    this.MemButton2.ForeColor = SystemColors.GrayText;
                    this.MemButton6.ForeColor = SystemColors.GrayText;
                    if (this.MemoriesPanel_enabled) triggerMemPanel.Start();
                    break;
                case "MR":
                    if (this.numBox.Text == "Fehler") ChangeOperationButtonsForeColor(SystemColors.ControlText);
                    if (this.last_memory == "" || this.last_memory == null) return;
                    this.calculationBox.Text = "";
                    this.first_num = this.last_memory;
                    this.numBox.Text = this.first_num;
                    break;
                case "M+":
                    if (this.numBox.Text == "Fehler") return;
                    if (this.last_memory == "" || this.last_memory == null)
                    {
                        this.MemButton1.ForeColor = SystemColors.ControlText;
                        this.MemButton2.ForeColor = SystemColors.ControlText;
                        this.MemButton6.ForeColor = SystemColors.ControlText;
                        MemButton.Text = this.first_num;
                        this.MemPanel.Controls.Add(MemButton);
                        this.MemPanel.Controls.SetChildIndex(MemButton, 0);
                        last_memory = MemButton.Text;
                    }

                    this.MemPanel.Controls[0].Text = (decimal.Parse(this.MemPanel.Controls[0].Text)
                        + decimal.Parse(this.first_num)).ToString();
                    break;
                case "M-":
                    if (this.numBox.Text == "Fehler") return;
                    if (this.last_memory == "" || this.last_memory == null)
                    {
                        this.MemButton1.ForeColor = SystemColors.ControlText;
                        this.MemButton2.ForeColor = SystemColors.ControlText;
                        this.MemButton6.ForeColor = SystemColors.ControlText;
                        MemButton.Text = this.first_num;
                        this.MemPanel.Controls.Add(MemButton);
                        this.MemPanel.Controls.SetChildIndex(MemButton, 0);
                        last_memory = MemButton.Text;
                    }

                    this.MemPanel.Controls[0].Text = (decimal.Parse(this.MemPanel.Controls[0].Text)
                        - decimal.Parse(this.first_num)).ToString();
                    break;
                case "MS":
                    if (this.numBox.Text == "Fehler") return;
                    this.MemButton1.ForeColor = SystemColors.ControlText;
                    this.MemButton2.ForeColor = SystemColors.ControlText;
                    this.MemButton6.ForeColor = SystemColors.ControlText;
                    MemButton.Text = this.first_num;
                    this.MemPanel.Controls.Add(MemButton);
                    this.MemPanel.Controls.SetChildIndex(MemButton, 0);
                    last_memory = MemButton.Text;
                    break;
                case "M":
                    if (this.last_memory == "" || this.last_memory == null) return;
                    triggerMemPanel.Start();
                    break;
            }
            if (this.numBox.Text != "Fehler")
            {
                this.MemButton3.ForeColor = SystemColors.ControlText;
                this.MemButton4.ForeColor = SystemColors.ControlText;
                this.MemButton5.ForeColor = SystemColors.ControlText;
            }

        }

        private void MemActionButton_Click(object sender, EventArgs e)
        {

            Button MemActionButton = sender as Button;

            int index = MemActionButton.Parent.Parent.Controls
                .IndexOf(MemActionButton.Parent);

            switch (MemActionButton.Text)
            {
                case "M+":
                    if (this.numBox.Text == "Fehler") return;
                    this.MemPanel.Controls[index].Text =
                        (decimal.Parse(this.MemPanel.Controls[index].Text)
                        + decimal.Parse(this.first_num)).ToString();
                    this.last_memory = this.MemPanel.Controls[0].Text;
                    break;
                case "M-":
                    if (this.numBox.Text == "Fehler") return;
                    this.MemPanel.Controls[index].Text =
                        (decimal.Parse(this.MemPanel.Controls[index].Text)
                        - decimal.Parse(this.first_num)).ToString();
                    this.last_memory = this.MemPanel.Controls[0].Text;
                    break;
                case "MC":
                    MemActionButton.Parent.Parent.Controls
                        .Remove(MemActionButton.Parent);
                    if (this.MemPanel.Controls.Count == 0)
                    {
                        this.last_memory = null;
                        this.triggerMemPanel.Start();
                        this.MemButton1.ForeColor = SystemColors.GrayText;
                        this.MemButton2.ForeColor = SystemColors.GrayText;
                        this.MemButton6.ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        this.last_memory = this.MemPanel.Controls[0].Text;
                    }
                    break;
            }
        }

        private void MemoryRecall_Click(object sender, EventArgs e)
        {
            if (this.numBox.Text == "Fehler") ChangeOperationButtonsForeColor(SystemColors.ControlText);
            Button button = sender as Button;
            this.operation = "";
            this.to_calculate = "";
            this.first_num = button.Text;
            this.numBox.Text = this.first_num;
            this.calculationBox.Text = "";
        }

        
        private void TriggerMenuButton_Click(object sender, EventArgs e)
        {
            if (MemoriesPanel_enabled)
            {
                triggerMemPanel.Start();
            }
            triggerMenu.Start();
        }

        
        private void NumButton_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.menuButton.Text != "") this.triggerMenu.Start();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter || e.KeyChar == '=')
            {
                equalButton.PerformClick();
                return;
            }
            else if (Regex.Match(e.KeyChar.ToString(), "[0-9]").Success)
            {
                ((Button)(this.Controls.OfType<Control>()
                    .Where(x => x.Text == e.KeyChar.ToString()).
                    FirstOrDefault())).PerformClick();
            }
            else if (Regex.Match(e.KeyChar.ToString(), "[,.]").Success)
            {
                decimalButton.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                DelButton.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                ClearButton.PerformClick();
            }
            else if (e.KeyChar == '²')
            {
                sqrButton.PerformClick();
            }
            else if (e.KeyChar == '%')
            {
                percentButton.PerformClick();
            }
            else if (e.KeyChar == '+')
            {
                addButton.PerformClick();
            }
            else if (e.KeyChar == '-')
            {
                minusButton.PerformClick();
            }
            else if (e.KeyChar == '*')
            {
                multiplyButton.PerformClick();
            }
            else if (e.KeyChar == '/')
            {
                divideButton.PerformClick();
            }
            else if (e.KeyChar == '(')
            {
                bracketOpen.PerformClick();
            }
            else if (e.KeyChar == ')')
            {
                bracketClose.PerformClick();
            }
        }
        private void NumButton_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (this.menuButton.Text != "") this.triggerMenu.Start();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();
            if (e.KeyCode == Keys.Delete)
            {
                ClearEntryButton.PerformClick();
            }
        }

        /*private void MemoryActionButtons_TriggerOn(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (object control in btn.Controls)
            {
                Button button = control as Button;
                button.Visible = true;
            }
        }
        private void MemoryActionButtons_TriggerOff(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (object control in btn.Controls)
            {
                Button button = control as Button;
                button.Visible = false;
            }
        }*/


        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.menuButton.Text == "")
            {
                if (triggerMemPanel.Enabled) return;
                this.menu.Location = new Point(Convert.ToInt32((- Math.Pow(1.75, -counter))
                    * this.menu.Width), this.menu.Location.Y);
                if (this.menu.Location.X >= 0)
                {
                    counter = 0;
                    this.menuButton.Text = "";
                    triggerMenu.Stop();
                }
            }
            else
            {
                this.menu.Location = new Point(Convert.ToInt32((- Math.Pow(1.75, counter / 1.5 - 10))
                    * (this.menu.Width + 1.5)), this.menu.Location.Y);
                if (this.menu.Location.X <= -this.menu.Width)
                {
                    counter = 0;
                    this.menuButton.Text = "";
                    triggerMenu.Stop();
                }
            }
            counter += 1;
        }

        
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (!this.MemoriesPanel_enabled)
            {
                if (triggerMenu.Enabled) return;
                this.MemPanel.Location = new Point(this.MemPanel.Location.X, this.Height - Convert.ToInt32((1-Math.Pow(1.5, -counter))* this.MemPanel.Height));
                if (this.MemPanel.Location.Y <= this.Height-this.MemPanel.Height)
                {
                    counter = 0;
                    this.MemoriesPanel_enabled = true;
                    triggerMemPanel.Stop();
                }
            }
            else
            {

                this.MemPanel.Location = new Point(this.MemPanel.Location.X, (this.Height-this.MemPanel.Height) +Convert.ToInt32((Math.Pow(2, counter / 1.5 - 10))
                    * (this.MemPanel.Height+1.5)));
                if (this.MemPanel.Location.Y >= this.Height)
                {
                    counter = 0;
                    this.MemoriesPanel_enabled = false;
                    triggerMemPanel.Stop();
                }
            }
            counter += 1;
        }

        
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.triggerMenu.Start();
            Button btn = sender as Button;
            if (btn.Text.EndsWith("Standard"))
            {
                Standard standard = new Standard()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false
                };
                MainForm.ActiveForm.Controls.Clear();
                MainForm.ActiveForm.Controls.Add(standard);
                standard.Show();
                standard.Focus();
            }
            else
            {
                return;
            }
        }
        private void AngleUnitButton_Click(object sender, EventArgs e)
        {
            AngleUnit[] angleUnit = new AngleUnit[] {
                AngleUnit.Rad,
                AngleUnit.Deg,
                AngleUnit.Grad,
            };
            parser.angleUnit = angleUnit[((int)parser.angleUnit + 1) % 3];
            Button button = sender as Button;
            button.Text = parser.angleUnit.ToString();
        }
        private void ExtendButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CurrentExtendedButton = button;
            switch (button.Name)
            {
                case "ExtendedButton1":
                    ExtendedPanel2.Height = 0;
                    ExtendedButton2.BackColor = SystemColors.Control;
                    extended_panel = this.ExtendedPanel1;
                    ExtendedPanelTimer.Start();
                    break;
                case "ExtendedButton2":
                    ExtendedPanel1.Height = 0;
                    ExtendedButton1.BackColor = SystemColors.Control;
                    extended_panel = this.ExtendedPanel2;
                    ExtendedPanelTimer.Start();
                    break;
            }
        }
        private void FunctionButtons_Click(object sender, EventArgs e)
        { 
            Button button = sender as Button;
           switch(button.Text)
            {
                case "2nd":
                    break;
                case "hyp":
                    break;
                case "⌈𝑥⌉":
                    addCertainFunc("ceil");
                    break;
                case "⌊𝑥⌋":
                    addCertainFunc("floor");
                    break;
                case "[𝑥]":
                    addCertainFunc("round");
                    break;
                case "| 𝑥 |":
                    addCertainFunc("abs");
                    break;
                case "rand":
                    this.first_num = new Random().NextDouble().ToString();
                        this.numBox.Text=this.first_num.ToString();
                    break;
                default:
                    addCertainFunc(button.Text);
                    break;
            }
        }


        private void Brackets_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.triggerMenu.Start();
            if (this.CurrentExtendedButton.BackColor != SystemColors.Control) this.ExtendedPanelTimer.Start();

            Button button = sender as Button;
            bool matched = Regex.Match("" + this.to_calculate, @"(\d|𝑒|π)$").Success, 
                matched_brackets_close = Regex.Match("" + this.to_calculate, @"\)$").Success,
                matched_brackets_open = Regex.Match("" + this.to_calculate, @"\($").Success,
                matched_any_operator  = !matched && !matched_brackets_close && !matched_brackets_open;
            switch (button.Text[0])
            {
                case '(':
                    if(this.number_is_written&&matched_any_operator)
                    {
                        this.to_calculate += this.first_num+"×";
                        this.number_is_written = false;
                    }
                    this.to_calculate += (matched && !(this.to_calculate == "" || this.to_calculate == null) || matched_brackets_close ? "×" : "") + "(";
                    this.brackets++;
                    this.bracketOpen.Text = "(" + (brackets > 0 ? Utils.PrintSubscripts(this.brackets) : "");
                    this.equal_pressed = false;
                    break;
                case ')':
                    if (this.brackets == 0 || matched) break;

                    else if (matched_brackets_open&&!number_is_written)
                    {
                        this.to_calculate += this.first_num;
                    }
                    this.to_calculate += (number_is_written ? this.first_num : "") + ")";

                    this.number_is_written = false;
                    this.first_num = "0";
                    if (!(button.Text.Length < 2) && button.Text[1] == '(')
                    {
                        this.to_calculate += "(";
                        break;
                    }
                    this.brackets--;
                    this.bracketOpen.Text = "(" + (brackets > 0 ? Utils.PrintSubscripts(this.brackets) : "");
                    break;

            }
            this.numBox.Text = this.first_num;
            this.calculationBox.Text = this.to_calculate;

        }




        public void ExtendedPanelTimer_Tick(object sender, EventArgs e)
        {
            if (this.CurrentExtendedButton.BackColor == SystemColors.Control)
            {
                this.extended_panel.Height = Convert.ToInt32((1 - Math.Pow(1.5, -counter))
                    * (this.ExtendedPanel_height + 10));
                if (this.extended_panel.Height >= ExtendedPanel_height)
                {
                    counter = 0;
                    this.CurrentExtendedButton.BackColor = SystemColors.ControlLight;
                    ExtendedPanelTimer.Stop();
                }
            }
            else
            {
                this.extended_panel.Height = this.ExtendedPanel_height - Convert.ToInt32((1 - Math.Pow(2, -counter))
                    * (this.ExtendedPanel_height + 10));
                if (this.extended_panel.Height <= 0)
                {
                    counter = 0;
                    this.CurrentExtendedButton.BackColor = SystemColors.Control;
                    ExtendedPanelTimer.Stop();
                }
            }
            counter += 1;
        }

        
        private void addCertainExponent(string name)
        {
            this.first_num += name;
            length_to_erase = name.Length;
            this.numBox.Text = this.first_num;
        }
        private void addCertainFunc(string name)
        {
            bool matched = Regex.Match("" + this.to_calculate, @"(\d|𝑒|π)$").Success, matched_brackets_close = Regex.Match("" + this.to_calculate, @"\)$").Success;
            this.to_calculate += (matched && !(this.to_calculate == "" || this.to_calculate == null) || matched_brackets_close ? "×" : "") + name + "(";
            this.brackets++;
            this.bracketOpen.Text = "(" + (brackets > 0 ? Utils.PrintSubscripts(this.brackets) : "");
            this.calculationBox.Text = this.to_calculate;
            this.equal_pressed = false;
        }
    }
}

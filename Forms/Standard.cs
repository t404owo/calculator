using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;




namespace Calculator
{
    public partial class Standard : Form
    {
        public string first_num, to_calculate, operation,
                      decimal_seprator, inversed_num, icons, last_memory;
        public bool second, MemoriesPanel_enabled, equal_pressed, replaceable, special_sepator_trigger;
        public int counter;
        public Button lastbutton;
        public Standard()
        {
            this.MemoriesPanel_enabled = false;
            this.equal_pressed = false;
            this.replaceable = false;
            first_num = "0";
            this.decimal_seprator =
                CultureInfo.CurrentUICulture.NumberFormat.
                            NumberDecimalSeparator.ToString();

            InitializeComponent();

            

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

            this.MemPanel.Width = this.Width;

            this.numBox.Text = new MathParser() { angleUnit = AngleUnit.Rad }.Parse("2yroot((acosh(1)+13)mod3^1-2*2/(4/2*2)+9)-3+(1/3*3)-1+fact(3)-6-logbase(10)(10)-1+log(100)+100%-1-100%*1+(100%/1)").ToString();
            
        }
        private void ChangeOperationButtonsForeColor(Color color)
        {
            Button[] buttons = new Button[] {
                this.percentButton, this.InverseButton, this.sqrtButton, this.sqrButton,
                this.devideButton, this.multiplyButton, this.minusButton, this.addButton,
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
            if (this.numBox.Text == "Fehler")
            {
                this.calculationBox.Text = to_calculate;
                this.numBox.Text = first_num;
                ChangeOperationButtonsForeColor(System.Drawing.SystemColors.ControlText);
            }
            if (this.equal_pressed)
            {
                this.first_num = "0";
                this.to_calculate = "";
                this.calculationBox.Text = to_calculate;
                this.numBox.Text = "0";
                this.equal_pressed = false;
            }
            this.inversed_num = "";

            if (this.operation != "" && (this.to_calculate == "0" || this.to_calculate == ""))
            {
                this.to_calculate = this.first_num.Replace(decimal_seprator, "");
                this.first_num = this.special_sepator_trigger ? this.first_num : "0";
            }

            Button NumButton = sender as Button;
            
            if (this.first_num == "0" || this.replaceable || this.special_sepator_trigger)
            {
                bool reply_to_this_thing = Regex.Match(numBox.Text, "[.,]").Success;
                if (NumButton.Text == "0") this.first_num = this.special_sepator_trigger || reply_to_this_thing ? this.numBox.Text + NumButton.Text : NumButton.Text;
                else this.first_num = this.special_sepator_trigger ? this.numBox.Text + NumButton.Text : NumButton.Text;
                this.replaceable = false;
                this.special_sepator_trigger = false;
                if (lastbutton != null) lastbutton.BackColor = SystemColors.ControlLight;
            }
            else this.first_num += NumButton.Text;
            this.numBox.Text = this.first_num;

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.numBox.Text == "Fehler") ChangeOperationButtonsForeColor(SystemColors.ControlText);
            this.inversed_num = "";
            Button OperationButton = sender as Button;
            switch (OperationButton.Text)
            {
                case "CE":
                    if (this.equal_pressed)
                    {
                        this.operation = "";
                        this.to_calculate = "";
                    }
                    this.first_num = "0";
                    this.calculationBox.Text = to_calculate + operation;
                    break;
                case "C":
                    this.first_num = "0";
                    this.to_calculate = "";
                    this.operation = "";
                    this.replaceable = false;
                    this.calculationBox.Text = "";
                    if (lastbutton != null) lastbutton.BackColor = SystemColors.ControlLight;
                    break;
                case "":
                    if (this.replaceable) return;
                    if (this.equal_pressed)
                    {
                        this.to_calculate = "";
                        this.calculationBox.Text = "";
                    }
                    if (Regex.Match(this.first_num, "E[0-9]*").Success)
                    {
                        this.first_num = Regex.Replace(this.first_num, "E.[0-9]*", "");
                        break;
                    }
                    this.first_num = this.first_num.Length == 1 ?
                        "0" :
                        this.first_num.Remove(first_num.Length - 1, 1);
                    break;
            }
            this.numBox.Text = this.first_num;
            this.equal_pressed = false;

        }
        private void SpecialOperation_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.numBox.Text == "Fehler") return;
            Button OperationButton = sender as Button;
            if (OperationButton.Text != "𝑥⁻¹") this.inversed_num = "";
            switch (OperationButton.Text)
            {
                case "%":
                    this.first_num = (double.Parse(this.first_num) / 100).ToString();
                    this.numBox.Text = this.first_num
                        ;
                    break;
                case "±":
                    this.first_num = (double.Parse(this.first_num) * -1).ToString();
                    this.numBox.Text = this.first_num;
                    break;
                case "𝑥²":
                    this.first_num = (Math.Pow(double.Parse(this.first_num), 2)).ToString();
                    this.numBox.Text = this.first_num;
                    break;
                case "√":
                    this.first_num = (Math.Sqrt(double.Parse(this.first_num))).ToString();
                    this.numBox.Text = Double.IsNaN(double.Parse(this.first_num)) ?
                        "Fehler" : this.first_num;
                    if (Double.IsNaN(double.Parse(this.first_num)))
                    {
                        ChangeOperationButtonsForeColor(SystemColors.GrayText);
                        this.first_num = "0";
                    }
                    break;
                case "𝑥⁻¹":
                    if ((this.inversed_num == "" || this.inversed_num == null) && first_num != "0")
                    {
                        this.inversed_num = first_num;
                        this.first_num = (1 / double.Parse(this.first_num)).ToString();
                        this.numBox.Text = this.first_num;
                    }
                    else if (first_num != "0")
                    {
                        this.first_num = inversed_num;
                        this.inversed_num = "";
                        this.numBox.Text = this.first_num;
                    }
                    break;
            }

        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.numBox.Text == "Fehler") return;
            this.inversed_num = "";
            first_num = (
                Regex.Match(this.first_num, "[,.]", RegexOptions.None, TimeSpan.FromSeconds(1)).Success
                &&
                !Regex.Match(this.first_num, "[,.][0-9]*", RegexOptions.None, TimeSpan.FromSeconds(1)).Success
                ) ? first_num + "0" : first_num;
            Button OperationButton = sender as Button;
            if (this.operation == OperationButton.Text && this.replaceable)
            {
                this.operation = "";
                this.first_num = this.to_calculate;
                this.to_calculate = "";

                OperationButton.BackColor = SystemColors.ControlLight;
                this.numBox.Text = first_num;
                this.calculationBox.Text = "";
                this.replaceable = false;
            }
            else if (this.replaceable)
            
            

            {
                this.operation = OperationButton.Text;
                if (lastbutton != null) lastbutton.BackColor = SystemColors.ControlLight;
                lastbutton = OperationButton;
                OperationButton.BackColor = Color.CornflowerBlue;
                this.calculationBox.Text = this.to_calculate + this.operation;
            }
            else
            {
                
                
                
                
                if (this.operation != "") EqualButton_Click(sender, e);
                this.to_calculate = this.first_num;
                
                this.operation = OperationButton.Text;
                if (lastbutton != null) lastbutton.BackColor = SystemColors.ControlLight;
                lastbutton = OperationButton;
                OperationButton.BackColor = Color.CornflowerBlue;
                
                this.calculationBox.Text = (!this.to_calculate.Contains("E") ?
                    this.to_calculate : "(" + this.to_calculate + ")")
                    + this.operation;
                this.equal_pressed = false;
                this.replaceable = true;
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            bool to_calculate_contains_E = false;
            if (this.menuButton.Text != "") this.menuButton.PerformClick();
            if (this.numBox.Text == "Fehler") return;
            Button button = sender as Button;
            if (button.Text == "=") this.equal_pressed = true;
            this.replaceable = false;
            this.inversed_num = "";
            if (this.to_calculate != null) to_calculate_contains_E = this.to_calculate.Contains("E");
            this.calculationBox.Text = (to_calculate_contains_E ? "(" + this.to_calculate + ")" : this.to_calculate) +
                (
                this.operation != "" ?
                this.operation +
                (this.first_num.StartsWith("-") || this.first_num.Contains("E") ?
                "(" + this.first_num + ")" : this.first_num) : "" 
                ) +
                "=";
            if (this.to_calculate == "0" && this.operation == "") this.calculationBox.Text = this.first_num;
            switch (this.operation)
            {
                case "+":
                    this.first_num = (double.Parse(this.to_calculate) + double.Parse(this.first_num)).ToString();
                    break;
                case "-":
                    this.first_num = (double.Parse(this.to_calculate) - double.Parse(this.first_num)).ToString();
                    break;
                case "×":
                    this.first_num = (double.Parse(this.to_calculate) * double.Parse(this.first_num)).ToString();
                    break;
                case "÷":
                    if (double.Parse(first_num) != 0) this.first_num = (double.Parse(this.to_calculate) / double.Parse(this.first_num)).ToString();
                    else
                    {
                        this.first_num = "0";
                        this.to_calculate = "";
                        this.numBox.Text = "Fehler";
                        ChangeOperationButtonsForeColor(SystemColors.GrayText);
                    }
                    break;
                default:
                    break;
            }
            this.numBox.Text = this.numBox.Text == "Fehler" ? this.numBox.Text : this.first_num;
            this.operation = "";
            if (this.lastbutton != null) this.lastbutton.BackColor = SystemColors.ControlLight;

        }

        private void DecimalSepratorButton_Click(object sender, EventArgs e)
        {
            if (this.numBox.Text == "Fehler") return;
            if (equal_pressed) return;
            this.inversed_num = "";

            
            Match match = Regex.Match(this.first_num, "[,.]", RegexOptions.None, TimeSpan.FromSeconds(1));
            if (!this.replaceable)
            {
                if (match.Success) return;
                this.first_num += decimal_seprator;
                this.numBox.Text = this.first_num;
            }
            else
            {
                this.first_num = "0" + decimal_seprator;
                this.numBox.Text = this.first_num;
                this.replaceable = false;
                this.special_sepator_trigger = true;
            }

        }

        
        private void MemoryButton_Click(Object sender, EventArgs e)
        {
            if (this.menuButton.Text != "") this.triggerMenu.Start();
            Button button = sender as Button;
            if (this.MemPanel.Controls.Count > 0) this.last_memory = this.MemPanel.Controls[0].Text;


            
            Button MemButton = new Button();
            MemButton.FlatAppearance.BorderSize = 0;
            MemButton.FlatStyle = FlatStyle.Flat;
            MemButton.Name = "Memorybutton" + (this.MemPanel.Controls.Count - 1).ToString();
            MemButton.Padding = new Padding(0, 2, Convert.ToInt32(DeviceDpi / 10), 8);
            MemButton.TabIndex = this.MemPanel.Controls.Count;
            MemButton.Location = new Point(0, 0);
            MemButton.Size = new Size(Convert.ToInt32(this.MemPanel.Width - 8), Convert.ToInt32(this.MemPanel.Width / 5));
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
                MemActionButton.Location = new Point(this.MemPanel.Width - Convert.ToInt32(i * DeviceDpi / 2.25) - Convert.ToInt32(DeviceDpi * 1.75 / 3), Convert.ToInt32(DeviceDpi / 3.2));
                MemActionButton.Padding = new Padding(0);
                MemActionButton.Text = MemActionButton_Action[2 - i];
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
                    this.equal_pressed = true;
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

                    this.MemPanel.Controls[0].Text = (double.Parse(this.MemPanel.Controls[0].Text) + double.Parse(this.first_num)).ToString();
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

                    this.MemPanel.Controls[0].Text = (double.Parse(this.MemPanel.Controls[0].Text) - double.Parse(this.first_num)).ToString();
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

            int index = MemActionButton.Parent.Parent.Controls.IndexOf(MemActionButton.Parent);

            switch (MemActionButton.Text)
            {
                case "M+":
                    if (this.numBox.Text == "Fehler") return;
                    this.MemPanel.Controls[index].Text = (double.Parse(this.MemPanel.Controls[index].Text) + double.Parse(this.first_num)).ToString();
                    this.last_memory = this.MemPanel.Controls[0].Text;
                    break;
                case "M-":
                    if (this.numBox.Text == "Fehler") return;
                    this.MemPanel.Controls[index].Text = (double.Parse(this.MemPanel.Controls[index].Text) - double.Parse(this.first_num)).ToString();
                    this.last_memory = this.MemPanel.Controls[0].Text;
                    break;
                case "MC":
                    MemActionButton.Parent.Parent.Controls.Remove(MemActionButton.Parent);
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
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                equalButton.PerformClick();
                return;
            }
            else if (Regex.Match(e.KeyChar.ToString(), "[0-9]").Success)
            {
                ((Button)(this.Controls.OfType<Control>().Where(x => x.Text == e.KeyChar.ToString()).FirstOrDefault())).PerformClick();
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
            else if (e.KeyChar.ToString() == "²")
            {
                sqrButton.PerformClick();
            }
            else if (e.KeyChar.ToString() == "%")
            {
                percentButton.PerformClick();
            }
            else if (e.KeyChar.ToString() == "+")
            {
                addButton.PerformClick();
            }
            else if (e.KeyChar.ToString() == "-")
            {
                minusButton.PerformClick();
            }
            else if (e.KeyChar.ToString() == "*")
            {
                multiplyButton.PerformClick();
            }
            else if (e.KeyChar.ToString() == "/")
            {
                devideButton.PerformClick();
            }
        }
        private void NumButton_OnKeyDown(object sender, KeyEventArgs e)
        {
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
                this.menu.Location = new Point(Convert.ToInt32((-Math.Pow(1.75, -counter))
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
                this.menu.Location = new Point(Convert.ToInt32((-Math.Pow(1.75, counter / 1.5 - 10))
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
                this.MemPanel.Location = new Point(this.MemPanel.Location.X, this.Height - Convert.ToInt32((1 - Math.Pow(1.5, -counter)) * this.MemPanel.Height));
                if (this.MemPanel.Location.Y <= this.Height - this.MemPanel.Height)
                {
                    counter = 0;
                    this.MemoriesPanel_enabled = true;
                    triggerMemPanel.Stop();
                }
            }
            else
            {

                this.MemPanel.Location = new Point(this.MemPanel.Location.X, (this.Height - this.MemPanel.Height) + Convert.ToInt32((Math.Pow(2, counter / 1.5 - 10))
                    * (this.MemPanel.Height + 1.5)));
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
            if (btn.Text.EndsWith("Scientific"))
            {
                Scientific scientific = new Scientific()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false
                };
                MainForm.ActiveForm.Controls.Clear();
                MainForm.ActiveForm.Controls.Add(scientific);
                scientific.Show();
                scientific.Focus();
            }
            else
            {
                return;
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

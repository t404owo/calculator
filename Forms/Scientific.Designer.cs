using System.Windows.Forms;

namespace Calculator
{
    partial class Scientific
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InverseButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.sqrButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.numButton7 = new System.Windows.Forms.Button();
            this.numButton8 = new System.Windows.Forms.Button();
            this.numButton9 = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.numButton4 = new System.Windows.Forms.Button();
            this.numButton5 = new System.Windows.Forms.Button();
            this.numButton6 = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.numButton1 = new System.Windows.Forms.Button();
            this.numButton2 = new System.Windows.Forms.Button();
            this.numButton3 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.numButton0 = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.MemButton1 = new System.Windows.Forms.Button();
            this.MemButton2 = new System.Windows.Forms.Button();
            this.MemButton3 = new System.Windows.Forms.Button();
            this.MemButton4 = new System.Windows.Forms.Button();
            this.MemButton5 = new System.Windows.Forms.Button();
            this.MemButton6 = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.numBox = new System.Windows.Forms.TextBox();
            this.calculationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.triggerMenu = new System.Windows.Forms.Timer(this.components);
            this.triggerMemPanel = new System.Windows.Forms.Timer(this.components);
            this.MemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ExtendedButton1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ExtendedButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bracketClose = new System.Windows.Forms.Button();
            this.ExpRtButton = new System.Windows.Forms.Button();
            this.SpecialExpButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.MainSecondButton = new System.Windows.Forms.Button();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.bracketOpen = new System.Windows.Forms.Button();
            this.PIButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.moduloButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.menuButton2 = new System.Windows.Forms.Button();
            this.menuButton1 = new System.Windows.Forms.Button();
            this.ExtendedPanel1 = new System.Windows.Forms.Panel();
            this.cotButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.cscButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.secButton = new System.Windows.Forms.Button();
            this.sineButton = new System.Windows.Forms.Button();
            this.hypButton = new System.Windows.Forms.Button();
            this.SecondTrigButton = new System.Windows.Forms.Button();
            this.ExtendedPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ExtendedPanel2 = new System.Windows.Forms.Panel();
            this.CeilingButton = new System.Windows.Forms.Button();
            this.RoundingButton = new System.Windows.Forms.Button();
            this.FloorButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.AbsButton = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.ExtendedPanel1.SuspendLayout();
            this.ExtendedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InverseButton
            // 
            this.InverseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InverseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.InverseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.InverseButton.FlatAppearance.BorderSize = 0;
            this.InverseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InverseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InverseButton.Location = new System.Drawing.Point(88, 329);
            this.InverseButton.Margin = new System.Windows.Forms.Padding(1);
            this.InverseButton.Name = "InverseButton";
            this.InverseButton.Size = new System.Drawing.Size(71, 43);
            this.InverseButton.TabIndex = 29;
            this.InverseButton.Text = "𝑥⁻¹";
            this.InverseButton.UseVisualStyleBackColor = false;
            this.InverseButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sqrtButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sqrtButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.sqrtButton.FlatAppearance.BorderSize = 0;
            this.sqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sqrtButton.Location = new System.Drawing.Point(15, 374);
            this.sqrtButton.Margin = new System.Windows.Forms.Padding(1);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(71, 43);
            this.sqrtButton.TabIndex = 1;
            this.sqrtButton.Text = "√𝑥";
            this.sqrtButton.UseVisualStyleBackColor = false;
            this.sqrtButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // sqrButton
            // 
            this.sqrButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sqrButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sqrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.sqrButton.FlatAppearance.BorderSize = 0;
            this.sqrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sqrButton.Location = new System.Drawing.Point(15, 329);
            this.sqrButton.Margin = new System.Windows.Forms.Padding(1);
            this.sqrButton.Name = "sqrButton";
            this.sqrButton.Size = new System.Drawing.Size(71, 43);
            this.sqrButton.TabIndex = 2;
            this.sqrButton.Text = "𝑥²";
            this.sqrButton.UseVisualStyleBackColor = false;
            this.sqrButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divideButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.divideButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.divideButton.FlatAppearance.BorderSize = 0;
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.divideButton.Location = new System.Drawing.Point(307, 374);
            this.divideButton.Margin = new System.Windows.Forms.Padding(1);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(71, 43);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // numButton7
            // 
            this.numButton7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton7.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton7.FlatAppearance.BorderSize = 0;
            this.numButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton7.Location = new System.Drawing.Point(88, 420);
            this.numButton7.Margin = new System.Windows.Forms.Padding(1);
            this.numButton7.Name = "numButton7";
            this.numButton7.Size = new System.Drawing.Size(71, 43);
            this.numButton7.TabIndex = 4;
            this.numButton7.Text = "7";
            this.numButton7.UseVisualStyleBackColor = false;
            this.numButton7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton8
            // 
            this.numButton8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton8.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton8.FlatAppearance.BorderSize = 0;
            this.numButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton8.Location = new System.Drawing.Point(161, 420);
            this.numButton8.Margin = new System.Windows.Forms.Padding(1);
            this.numButton8.Name = "numButton8";
            this.numButton8.Size = new System.Drawing.Size(71, 43);
            this.numButton8.TabIndex = 5;
            this.numButton8.Text = "8";
            this.numButton8.UseVisualStyleBackColor = false;
            this.numButton8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton9
            // 
            this.numButton9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton9.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton9.FlatAppearance.BorderSize = 0;
            this.numButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton9.Location = new System.Drawing.Point(234, 420);
            this.numButton9.Margin = new System.Windows.Forms.Padding(1);
            this.numButton9.Name = "numButton9";
            this.numButton9.Size = new System.Drawing.Size(71, 43);
            this.numButton9.TabIndex = 6;
            this.numButton9.Text = "9";
            this.numButton9.UseVisualStyleBackColor = false;
            this.numButton9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiplyButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.multiplyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.multiplyButton.FlatAppearance.BorderSize = 0;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.multiplyButton.Location = new System.Drawing.Point(307, 420);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(1);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(71, 43);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // numButton4
            // 
            this.numButton4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton4.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton4.FlatAppearance.BorderSize = 0;
            this.numButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton4.Location = new System.Drawing.Point(88, 465);
            this.numButton4.Margin = new System.Windows.Forms.Padding(1);
            this.numButton4.Name = "numButton4";
            this.numButton4.Size = new System.Drawing.Size(71, 43);
            this.numButton4.TabIndex = 8;
            this.numButton4.Text = "4";
            this.numButton4.UseVisualStyleBackColor = false;
            this.numButton4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton5
            // 
            this.numButton5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton5.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton5.FlatAppearance.BorderSize = 0;
            this.numButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton5.Location = new System.Drawing.Point(161, 465);
            this.numButton5.Margin = new System.Windows.Forms.Padding(1);
            this.numButton5.Name = "numButton5";
            this.numButton5.Size = new System.Drawing.Size(71, 43);
            this.numButton5.TabIndex = 9;
            this.numButton5.Text = "5";
            this.numButton5.UseVisualStyleBackColor = false;
            this.numButton5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton6
            // 
            this.numButton6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton6.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton6.FlatAppearance.BorderSize = 0;
            this.numButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton6.Location = new System.Drawing.Point(234, 465);
            this.numButton6.Margin = new System.Windows.Forms.Padding(1);
            this.numButton6.Name = "numButton6";
            this.numButton6.Size = new System.Drawing.Size(71, 43);
            this.numButton6.TabIndex = 10;
            this.numButton6.Text = "6";
            this.numButton6.UseVisualStyleBackColor = false;
            this.numButton6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minusButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusButton.Location = new System.Drawing.Point(307, 465);
            this.minusButton.Margin = new System.Windows.Forms.Padding(1);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(71, 43);
            this.minusButton.TabIndex = 15;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // numButton1
            // 
            this.numButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton1.FlatAppearance.BorderSize = 0;
            this.numButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton1.Location = new System.Drawing.Point(88, 511);
            this.numButton1.Margin = new System.Windows.Forms.Padding(1);
            this.numButton1.Name = "numButton1";
            this.numButton1.Size = new System.Drawing.Size(71, 43);
            this.numButton1.TabIndex = 12;
            this.numButton1.Text = "1";
            this.numButton1.UseVisualStyleBackColor = false;
            this.numButton1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton2
            // 
            this.numButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton2.FlatAppearance.BorderSize = 0;
            this.numButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton2.Location = new System.Drawing.Point(161, 511);
            this.numButton2.Margin = new System.Windows.Forms.Padding(1);
            this.numButton2.Name = "numButton2";
            this.numButton2.Size = new System.Drawing.Size(71, 43);
            this.numButton2.TabIndex = 13;
            this.numButton2.Text = "2";
            this.numButton2.UseVisualStyleBackColor = false;
            this.numButton2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton3
            // 
            this.numButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton3.FlatAppearance.BorderSize = 0;
            this.numButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton3.Location = new System.Drawing.Point(234, 511);
            this.numButton3.Margin = new System.Windows.Forms.Padding(1);
            this.numButton3.Name = "numButton3";
            this.numButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numButton3.Size = new System.Drawing.Size(71, 43);
            this.numButton3.TabIndex = 14;
            this.numButton3.Text = "3";
            this.numButton3.UseVisualStyleBackColor = false;
            this.numButton3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(307, 511);
            this.addButton.Margin = new System.Windows.Forms.Padding(1);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(71, 43);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlusMinusButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlusMinusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.PlusMinusButton.FlatAppearance.BorderSize = 0;
            this.PlusMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlusMinusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlusMinusButton.Location = new System.Drawing.Point(88, 556);
            this.PlusMinusButton.Margin = new System.Windows.Forms.Padding(1);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(71, 43);
            this.PlusMinusButton.TabIndex = 31;
            this.PlusMinusButton.Text = "±";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // numButton0
            // 
            this.numButton0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton0.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton0.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton0.FlatAppearance.BorderSize = 0;
            this.numButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numButton0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton0.Location = new System.Drawing.Point(161, 556);
            this.numButton0.Margin = new System.Windows.Forms.Padding(1);
            this.numButton0.Name = "numButton0";
            this.numButton0.Size = new System.Drawing.Size(71, 43);
            this.numButton0.TabIndex = 17;
            this.numButton0.Text = "0";
            this.numButton0.UseVisualStyleBackColor = false;
            this.numButton0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decimalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.decimalButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.decimalButton.FlatAppearance.BorderSize = 0;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.decimalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decimalButton.Location = new System.Drawing.Point(234, 556);
            this.decimalButton.Margin = new System.Windows.Forms.Padding(1);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(71, 43);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.DecimalSepratorButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.equalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.equalButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equalButton.Location = new System.Drawing.Point(307, 556);
            this.equalButton.Margin = new System.Windows.Forms.Padding(1);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(71, 43);
            this.equalButton.TabIndex = 19;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // MemButton1
            // 
            this.MemButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MemButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemButton1.Location = new System.Drawing.Point(16, 187);
            this.MemButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemButton1.Name = "MemButton1";
            this.MemButton1.Size = new System.Drawing.Size(56, 38);
            this.MemButton1.TabIndex = 32;
            this.MemButton1.Text = "MC";
            this.MemButton1.UseVisualStyleBackColor = true;
            this.MemButton1.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton2
            // 
            this.MemButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MemButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemButton2.Location = new System.Drawing.Point(79, 187);
            this.MemButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemButton2.Name = "MemButton2";
            this.MemButton2.Size = new System.Drawing.Size(56, 38);
            this.MemButton2.TabIndex = 33;
            this.MemButton2.Text = "MR";
            this.MemButton2.UseVisualStyleBackColor = true;
            this.MemButton2.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton3
            // 
            this.MemButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MemButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemButton3.Location = new System.Drawing.Point(143, 187);
            this.MemButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemButton3.Name = "MemButton3";
            this.MemButton3.Size = new System.Drawing.Size(56, 38);
            this.MemButton3.TabIndex = 34;
            this.MemButton3.Text = "M+";
            this.MemButton3.UseVisualStyleBackColor = true;
            this.MemButton3.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton4
            // 
            this.MemButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MemButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemButton4.Location = new System.Drawing.Point(204, 187);
            this.MemButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemButton4.Name = "MemButton4";
            this.MemButton4.Size = new System.Drawing.Size(56, 38);
            this.MemButton4.TabIndex = 37;
            this.MemButton4.Text = "M-";
            this.MemButton4.UseVisualStyleBackColor = true;
            this.MemButton4.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton5
            // 
            this.MemButton5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MemButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemButton5.Location = new System.Drawing.Point(264, 187);
            this.MemButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemButton5.Name = "MemButton5";
            this.MemButton5.Size = new System.Drawing.Size(56, 38);
            this.MemButton5.TabIndex = 36;
            this.MemButton5.Text = "MS";
            this.MemButton5.UseVisualStyleBackColor = true;
            this.MemButton5.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton6
            // 
            this.MemButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MemButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemButton6.Location = new System.Drawing.Point(325, 187);
            this.MemButton6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MemButton6.Name = "MemButton6";
            this.MemButton6.Size = new System.Drawing.Size(53, 38);
            this.MemButton6.TabIndex = 35;
            this.MemButton6.Text = "M";
            this.MemButton6.UseVisualStyleBackColor = true;
            this.MemButton6.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(12, 7);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(61, 63);
            this.menuButton.TabIndex = 38;
            this.menuButton.Text = "";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.TriggerMenuButton_Click);
            // 
            // numBox
            // 
            this.numBox.BackColor = System.Drawing.SystemColors.Control;
            this.numBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numBox.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold);
            this.numBox.Location = new System.Drawing.Point(23, 101);
            this.numBox.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.numBox.Name = "numBox";
            this.numBox.ReadOnly = true;
            this.numBox.Size = new System.Drawing.Size(349, 49);
            this.numBox.TabIndex = 20;
            this.numBox.Text = "0";
            this.numBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculationBox
            // 
            this.calculationBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calculationBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calculationBox.Enabled = false;
            this.calculationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calculationBox.Location = new System.Drawing.Point(23, 65);
            this.calculationBox.Margin = new System.Windows.Forms.Padding(11, 1, 11, 2);
            this.calculationBox.Name = "calculationBox";
            this.calculationBox.ReadOnly = true;
            this.calculationBox.Size = new System.Drawing.Size(349, 23);
            this.calculationBox.TabIndex = 21;
            this.calculationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 57);
            this.label1.TabIndex = 39;
            this.label1.Text = "Scientific";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // triggerMenu
            // 
            this.triggerMenu.Interval = 4;
            this.triggerMenu.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // triggerMemPanel
            // 
            this.triggerMemPanel.Interval = 4;
            this.triggerMemPanel.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // MemPanel
            // 

            this.MemPanel.HorizontalScroll.Maximum = 0;
            this.MemPanel.AutoScroll = false;
            this.MemPanel.VerticalScroll.Visible = false;
            this.MemPanel.AutoScroll = true;
            this.MemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemPanel.Location = new System.Drawing.Point(0, 610);
            this.MemPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemPanel.Name = "MemPanel";
            this.MemPanel.Size = new System.Drawing.Size(395, 382);
            this.MemPanel.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 30);
            this.button1.TabIndex = 42;
            this.button1.Text = "Rad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AngleUnitButton_Click);
            // 
            // ExtendedButton1
            // 
            this.ExtendedButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ExtendedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtendedButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExtendedButton1.Location = new System.Drawing.Point(15, 231);
            this.ExtendedButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExtendedButton1.Name = "ExtendedButton1";
            this.ExtendedButton1.Size = new System.Drawing.Size(180, 43);
            this.ExtendedButton1.TabIndex = 44;
            this.ExtendedButton1.Text = "◿ Trigonometrie ";
            this.ExtendedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExtendedButton1.UseVisualStyleBackColor = true;
            this.ExtendedButton1.Click += new System.EventHandler(this.ExtendButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(-89, -182);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 52);
            this.button5.TabIndex = 48;
            this.button5.Text = "%";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // ExtendedButton2
            // 
            this.ExtendedButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ExtendedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtendedButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExtendedButton2.Location = new System.Drawing.Point(215, 231);
            this.ExtendedButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExtendedButton2.Name = "ExtendedButton2";
            this.ExtendedButton2.Size = new System.Drawing.Size(161, 43);
            this.ExtendedButton2.TabIndex = 49;
            this.ExtendedButton2.Text = "ƒ Funktionen ";
            this.ExtendedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExtendedButton2.UseVisualStyleBackColor = true;
            this.ExtendedButton2.Click += new System.EventHandler(this.ExtendButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 1);
            this.label2.TabIndex = 50;
            this.label2.Text = "label2";
            // 
            // bracketClose
            // 
            this.bracketClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bracketClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.bracketClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bracketClose.FlatAppearance.BorderSize = 0;
            this.bracketClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bracketClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bracketClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bracketClose.Location = new System.Drawing.Point(161, 374);
            this.bracketClose.Margin = new System.Windows.Forms.Padding(1);
            this.bracketClose.Name = "bracketClose";
            this.bracketClose.Size = new System.Drawing.Size(71, 43);
            this.bracketClose.TabIndex = 52;
            this.bracketClose.Text = ")";
            this.bracketClose.UseVisualStyleBackColor = false;
            this.bracketClose.Click += new System.EventHandler(this.Brackets_Click);
            // 
            // ExpRtButton
            // 
            this.ExpRtButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExpRtButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpRtButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ExpRtButton.FlatAppearance.BorderSize = 0;
            this.ExpRtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpRtButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpRtButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExpRtButton.Location = new System.Drawing.Point(15, 420);
            this.ExpRtButton.Margin = new System.Windows.Forms.Padding(1);
            this.ExpRtButton.Name = "ExpRtButton";
            this.ExpRtButton.Size = new System.Drawing.Size(71, 43);
            this.ExpRtButton.TabIndex = 53;
            this.ExpRtButton.Text = "xʸ";
            this.ExpRtButton.UseVisualStyleBackColor = false;
            this.ExpRtButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // SpecialExpButton
            // 
            this.SpecialExpButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpecialExpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpecialExpButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.SpecialExpButton.FlatAppearance.BorderSize = 0;
            this.SpecialExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpecialExpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialExpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SpecialExpButton.Location = new System.Drawing.Point(15, 465);
            this.SpecialExpButton.Margin = new System.Windows.Forms.Padding(1);
            this.SpecialExpButton.Name = "SpecialExpButton";
            this.SpecialExpButton.Size = new System.Drawing.Size(71, 43);
            this.SpecialExpButton.TabIndex = 54;
            this.SpecialExpButton.Text = "10ˣ";
            this.SpecialExpButton.UseVisualStyleBackColor = false;
            this.SpecialExpButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button10.Cursor = System.Windows.Forms.Cursors.Default;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(15, 511);
            this.button10.Margin = new System.Windows.Forms.Padding(1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 43);
            this.button10.TabIndex = 55;
            this.button10.Text = "log";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button11.Cursor = System.Windows.Forms.Cursors.Default;
            this.button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(15, 556);
            this.button11.Margin = new System.Windows.Forms.Padding(1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 43);
            this.button11.TabIndex = 56;
            this.button11.Text = "eʸ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.percentButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.percentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.percentButton.FlatAppearance.BorderSize = 0;
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.percentButton.Location = new System.Drawing.Point(88, 283);
            this.percentButton.Margin = new System.Windows.Forms.Padding(1, 6, 1, 1);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(71, 43);
            this.percentButton.TabIndex = 30;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearEntryButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearEntryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClearEntryButton.FlatAppearance.BorderSize = 0;
            this.ClearEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearEntryButton.Location = new System.Drawing.Point(161, 283);
            this.ClearEntryButton.Margin = new System.Windows.Forms.Padding(1, 6, 1, 1);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(71, 43);
            this.ClearEntryButton.TabIndex = 28;
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.UseVisualStyleBackColor = false;
            this.ClearEntryButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Location = new System.Drawing.Point(234, 283);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(1, 6, 1, 1);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(71, 43);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.DelButton.FlatAppearance.BorderSize = 0;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelButton.Location = new System.Drawing.Point(307, 283);
            this.DelButton.Margin = new System.Windows.Forms.Padding(1, 6, 1, 1);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(71, 43);
            this.DelButton.TabIndex = 22;
            this.DelButton.Text = "";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // MainSecondButton
            // 
            this.MainSecondButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainSecondButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainSecondButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MainSecondButton.FlatAppearance.BorderSize = 0;
            this.MainSecondButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainSecondButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSecondButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainSecondButton.Location = new System.Drawing.Point(15, 283);
            this.MainSecondButton.Margin = new System.Windows.Forms.Padding(1, 6, 1, 1);
            this.MainSecondButton.Name = "MainSecondButton";
            this.MainSecondButton.Size = new System.Drawing.Size(71, 43);
            this.MainSecondButton.TabIndex = 51;
            this.MainSecondButton.Text = "2nd";
            this.MainSecondButton.UseVisualStyleBackColor = false;
            this.MainSecondButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // FactorialButton
            // 
            this.FactorialButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FactorialButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.FactorialButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.FactorialButton.FlatAppearance.BorderSize = 0;
            this.FactorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FactorialButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactorialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FactorialButton.Location = new System.Drawing.Point(234, 374);
            this.FactorialButton.Margin = new System.Windows.Forms.Padding(1);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(71, 43);
            this.FactorialButton.TabIndex = 57;
            this.FactorialButton.Text = "n!";
            this.FactorialButton.UseVisualStyleBackColor = false;
            this.FactorialButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // bracketOpen
            // 
            this.bracketOpen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bracketOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.bracketOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bracketOpen.FlatAppearance.BorderSize = 0;
            this.bracketOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bracketOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bracketOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bracketOpen.Location = new System.Drawing.Point(88, 374);
            this.bracketOpen.Margin = new System.Windows.Forms.Padding(1);
            this.bracketOpen.Name = "bracketOpen";
            this.bracketOpen.Size = new System.Drawing.Size(71, 43);
            this.bracketOpen.TabIndex = 58;
            this.bracketOpen.Text = "(";
            this.bracketOpen.UseVisualStyleBackColor = false;
            this.bracketOpen.Click += new System.EventHandler(this.Brackets_Click);
            // 
            // PIButton
            // 
            this.PIButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PIButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PIButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.PIButton.FlatAppearance.BorderSize = 0;
            this.PIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PIButton.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PIButton.Location = new System.Drawing.Point(161, 329);
            this.PIButton.Margin = new System.Windows.Forms.Padding(1);
            this.PIButton.Name = "PIButton";
            this.PIButton.Size = new System.Drawing.Size(71, 43);
            this.PIButton.TabIndex = 59;
            this.PIButton.Text = "π";
            this.PIButton.UseVisualStyleBackColor = false;
            this.PIButton.Click += new System.EventHandler(this.SpecialNumber_Click);
            // 
            // EButton
            // 
            this.EButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.EButton.FlatAppearance.BorderSize = 0;
            this.EButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EButton.Location = new System.Drawing.Point(234, 329);
            this.EButton.Margin = new System.Windows.Forms.Padding(1);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(71, 43);
            this.EButton.TabIndex = 60;
            this.EButton.Text = "e";
            this.EButton.UseVisualStyleBackColor = false;
            this.EButton.Click += new System.EventHandler(this.SpecialNumber_Click);
            // 
            // moduloButton
            // 
            this.moduloButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.moduloButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.moduloButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.moduloButton.FlatAppearance.BorderSize = 0;
            this.moduloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moduloButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moduloButton.Location = new System.Drawing.Point(307, 329);
            this.moduloButton.Margin = new System.Windows.Forms.Padding(1);
            this.moduloButton.Name = "moduloButton";
            this.moduloButton.Size = new System.Drawing.Size(71, 43);
            this.moduloButton.TabIndex = 61;
            this.moduloButton.Text = "mod";
            this.moduloButton.UseVisualStyleBackColor = false;
            this.moduloButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.menuButton2);
            this.menu.Controls.Add(this.menuButton1);
            this.menu.Location = new System.Drawing.Point(-299, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(299, 610);
            this.menu.TabIndex = 62;
            // 
            // menuButton2
            // 
            this.menuButton2.FlatAppearance.BorderSize = 0;
            this.menuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuButton2.Location = new System.Drawing.Point(0, 148);
            this.menuButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.menuButton2.Size = new System.Drawing.Size(345, 75);
            this.menuButton2.TabIndex = 1;
            this.menuButton2.Text = " Wissenschaftlich";
            this.menuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton2.UseVisualStyleBackColor = true;
            this.menuButton2.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // menuButton1
            // 
            this.menuButton1.FlatAppearance.BorderSize = 0;
            this.menuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuButton1.Location = new System.Drawing.Point(0, 69);
            this.menuButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.menuButton1.Size = new System.Drawing.Size(345, 75);
            this.menuButton1.TabIndex = 0;
            this.menuButton1.Text = " Standard";
            this.menuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton1.UseVisualStyleBackColor = true;
            this.menuButton1.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ExtendedPanel1
            // 
            this.ExtendedPanel1.Controls.Add(this.cotButton);
            this.ExtendedPanel1.Controls.Add(this.tanButton);
            this.ExtendedPanel1.Controls.Add(this.cscButton);
            this.ExtendedPanel1.Controls.Add(this.cosButton);
            this.ExtendedPanel1.Controls.Add(this.secButton);
            this.ExtendedPanel1.Controls.Add(this.sineButton);
            this.ExtendedPanel1.Controls.Add(this.hypButton);
            this.ExtendedPanel1.Controls.Add(this.SecondTrigButton);
            this.ExtendedPanel1.Location = new System.Drawing.Point(15, 277);
            this.ExtendedPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExtendedPanel1.Name = "ExtendedPanel1";
            this.ExtendedPanel1.Size = new System.Drawing.Size(332, 0);
            this.ExtendedPanel1.TabIndex = 65;
            // 
            // cotButton
            // 
            this.cotButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cotButton.FlatAppearance.BorderSize = 0;
            this.cotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cotButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cotButton.Location = new System.Drawing.Point(249, 69);
            this.cotButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cotButton.Name = "cotButton";
            this.cotButton.Size = new System.Drawing.Size(75, 53);
            this.cotButton.TabIndex = 7;
            this.cotButton.Text = "cot";
            this.cotButton.UseVisualStyleBackColor = false;
            this.cotButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // tanButton
            // 
            this.tanButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tanButton.FlatAppearance.BorderSize = 0;
            this.tanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tanButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanButton.Location = new System.Drawing.Point(249, 6);
            this.tanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(75, 55);
            this.tanButton.TabIndex = 6;
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = false;
            this.tanButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // cscButton
            // 
            this.cscButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cscButton.FlatAppearance.BorderSize = 0;
            this.cscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cscButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cscButton.Location = new System.Drawing.Point(168, 69);
            this.cscButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cscButton.Name = "cscButton";
            this.cscButton.Size = new System.Drawing.Size(75, 53);
            this.cscButton.TabIndex = 5;
            this.cscButton.Text = "csc";
            this.cscButton.UseVisualStyleBackColor = false;
            this.cscButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // cosButton
            // 
            this.cosButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cosButton.FlatAppearance.BorderSize = 0;
            this.cosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cosButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosButton.Location = new System.Drawing.Point(168, 6);
            this.cosButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(75, 55);
            this.cosButton.TabIndex = 4;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = false;
            this.cosButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // secButton
            // 
            this.secButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.secButton.FlatAppearance.BorderSize = 0;
            this.secButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secButton.Location = new System.Drawing.Point(87, 69);
            this.secButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secButton.Name = "secButton";
            this.secButton.Size = new System.Drawing.Size(75, 53);
            this.secButton.TabIndex = 3;
            this.secButton.Text = "sec";
            this.secButton.UseVisualStyleBackColor = false;
            this.secButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // sineButton
            // 
            this.sineButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sineButton.FlatAppearance.BorderSize = 0;
            this.sineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sineButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sineButton.Location = new System.Drawing.Point(87, 6);
            this.sineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sineButton.Name = "sineButton";
            this.sineButton.Size = new System.Drawing.Size(75, 55);
            this.sineButton.TabIndex = 2;
            this.sineButton.Text = "sin";
            this.sineButton.UseVisualStyleBackColor = false;
            this.sineButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // hypButton
            // 
            this.hypButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hypButton.FlatAppearance.BorderSize = 0;
            this.hypButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hypButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypButton.Location = new System.Drawing.Point(5, 69);
            this.hypButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hypButton.Name = "hypButton";
            this.hypButton.Size = new System.Drawing.Size(75, 53);
            this.hypButton.TabIndex = 1;
            this.hypButton.Text = "hyp";
            this.hypButton.UseVisualStyleBackColor = false;
            this.hypButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // SecondTrigButton
            // 
            this.SecondTrigButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SecondTrigButton.FlatAppearance.BorderSize = 0;
            this.SecondTrigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondTrigButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondTrigButton.Location = new System.Drawing.Point(5, 6);
            this.SecondTrigButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondTrigButton.Name = "SecondTrigButton";
            this.SecondTrigButton.Size = new System.Drawing.Size(75, 55);
            this.SecondTrigButton.TabIndex = 0;
            this.SecondTrigButton.Text = "2nd";
            this.SecondTrigButton.UseVisualStyleBackColor = false;
            this.SecondTrigButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // ExtendedPanelTimer
            // 
            this.ExtendedPanelTimer.Interval = 4;
            this.ExtendedPanelTimer.Tick += new System.EventHandler(this.ExtendedPanelTimer_Tick);
            // 
            // ExtendedPanel2
            // 
            this.ExtendedPanel2.Controls.Add(this.CeilingButton);
            this.ExtendedPanel2.Controls.Add(this.RoundingButton);
            this.ExtendedPanel2.Controls.Add(this.FloorButton);
            this.ExtendedPanel2.Controls.Add(this.RandomButton);
            this.ExtendedPanel2.Controls.Add(this.AbsButton);
            this.ExtendedPanel2.Location = new System.Drawing.Point(71, 277);
            this.ExtendedPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExtendedPanel2.Name = "ExtendedPanel2";
            this.ExtendedPanel2.Size = new System.Drawing.Size(251, 0);
            this.ExtendedPanel2.TabIndex = 66;
            // 
            // CeilingButton
            // 
            this.CeilingButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CeilingButton.FlatAppearance.BorderSize = 0;
            this.CeilingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CeilingButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CeilingButton.Location = new System.Drawing.Point(168, 6);
            this.CeilingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CeilingButton.Name = "CeilingButton";
            this.CeilingButton.Size = new System.Drawing.Size(75, 55);
            this.CeilingButton.TabIndex = 4;
            this.CeilingButton.Text = "⌈𝑥⌉";
            this.CeilingButton.UseVisualStyleBackColor = false;
            this.CeilingButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // RoundingButton
            // 
            this.RoundingButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoundingButton.FlatAppearance.BorderSize = 0;
            this.RoundingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoundingButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundingButton.Location = new System.Drawing.Point(87, 69);
            this.RoundingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoundingButton.Name = "RoundingButton";
            this.RoundingButton.Size = new System.Drawing.Size(75, 53);
            this.RoundingButton.TabIndex = 3;
            this.RoundingButton.Text = "[𝑥]";
            this.RoundingButton.UseVisualStyleBackColor = false;
            this.RoundingButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // FloorButton
            // 
            this.FloorButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FloorButton.FlatAppearance.BorderSize = 0;
            this.FloorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FloorButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorButton.Location = new System.Drawing.Point(87, 6);
            this.FloorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FloorButton.Name = "FloorButton";
            this.FloorButton.Size = new System.Drawing.Size(75, 55);
            this.FloorButton.TabIndex = 2;
            this.FloorButton.Text = "⌊𝑥⌋";
            this.FloorButton.UseVisualStyleBackColor = false;
            this.FloorButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RandomButton.FlatAppearance.BorderSize = 0;
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.Location = new System.Drawing.Point(5, 69);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(75, 53);
            this.RandomButton.TabIndex = 1;
            this.RandomButton.Text = "rand";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // AbsButton
            // 
            this.AbsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AbsButton.FlatAppearance.BorderSize = 0;
            this.AbsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsButton.Location = new System.Drawing.Point(5, 6);
            this.AbsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AbsButton.Name = "AbsButton";
            this.AbsButton.Size = new System.Drawing.Size(75, 55);
            this.AbsButton.TabIndex = 0;
            this.AbsButton.Text = "| 𝑥 |";
            this.AbsButton.UseVisualStyleBackColor = false;
            this.AbsButton.Click += new System.EventHandler(this.FunctionButtons_Click);
            // 
            // Scientific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(395, 610);
            this.Controls.Add(this.MemPanel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.ExtendedPanel2);
            this.Controls.Add(this.ExtendedPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtendedButton2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExtendedButton1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.SpecialExpButton);
            this.Controls.Add(this.ExpRtButton);
            this.Controls.Add(this.bracketClose);
            this.Controls.Add(this.MainSecondButton);
            this.Controls.Add(this.moduloButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.PIButton);
            this.Controls.Add(this.bracketOpen);
            this.Controls.Add(this.FactorialButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.InverseButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.sqrButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.numButton7);
            this.Controls.Add(this.numButton8);
            this.Controls.Add(this.numButton9);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.numButton4);
            this.Controls.Add(this.numButton5);
            this.Controls.Add(this.numButton6);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.numButton1);
            this.Controls.Add(this.numButton2);
            this.Controls.Add(this.numButton3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.numButton0);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.MemButton1);
            this.Controls.Add(this.MemButton2);
            this.Controls.Add(this.MemButton3);
            this.Controls.Add(this.MemButton4);
            this.Controls.Add(this.MemButton5);
            this.Controls.Add(this.MemButton6);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.calculationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Scientific";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechner (v1.0.0b)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumButton_OnKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumButton_OnKeyPress);
            this.menu.ResumeLayout(false);
            this.ExtendedPanel1.ResumeLayout(false);
            this.ExtendedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button InverseButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button sqrButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button numButton7;
        private System.Windows.Forms.Button numButton8;
        private System.Windows.Forms.Button numButton9;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button numButton4;
        private System.Windows.Forms.Button numButton5;
        private System.Windows.Forms.Button numButton6;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button numButton1;
        private System.Windows.Forms.Button numButton2;
        private System.Windows.Forms.Button numButton3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button numButton0;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.TextBox calculationBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Button MemButton1;
        private System.Windows.Forms.Button MemButton2;
        private System.Windows.Forms.Button MemButton3;
        private System.Windows.Forms.Button MemButton4;
        private System.Windows.Forms.Button MemButton5;
        private System.Windows.Forms.Button MemButton6;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer triggerMenu;
        private System.Windows.Forms.Timer triggerMemPanel;
        private FlowLayoutPanel MemPanel;
        private Button button1;
        private Button ExtendedButton1;
        private Button button5;
        private Button ExtendedButton2;
        private Label label2;
        private Button bracketClose;
        private Button ExpRtButton;
        private Button SpecialExpButton;
        private Button button10;
        private Button button11;
        private Button percentButton;
        private Button ClearEntryButton;
        private Button ClearButton;
        private Button DelButton;
        private Button MainSecondButton;
        private Button FactorialButton;
        private Button bracketOpen;
        private Button PIButton;
        private Button EButton;
        private Button moduloButton;
        private Panel menu;
        private Button menuButton2;
        private Button menuButton1;
        private Panel ExtendedPanel1;
        private Button cotButton;
        private Button tanButton;
        private Button cscButton;
        private Button cosButton;
        private Button secButton;
        private Button sineButton;
        private Button hypButton;
        private Button SecondTrigButton;
        private Timer ExtendedPanelTimer;
        private Panel ExtendedPanel2;
        private Button CeilingButton;
        private Button RoundingButton;
        private Button FloorButton;
        private Button RandomButton;
        private Button AbsButton;
    }
}


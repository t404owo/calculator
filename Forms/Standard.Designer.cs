using System.Windows.Forms;

namespace Calculator
{
    partial class Standard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standard));
            this.percentButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.InverseButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.sqrButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
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
            this.menu = new System.Windows.Forms.Panel();
            this.menuButton2 = new System.Windows.Forms.Button();
            this.menuButton1 = new System.Windows.Forms.Button();
            this.triggerMenu = new System.Windows.Forms.Timer(this.components);
            this.triggerMemPanel = new System.Windows.Forms.Timer(this.components);
            this.MemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.percentButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.percentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.percentButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.percentButton, "percentButton");
            this.percentButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.percentButton.Name = "percentButton";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearEntryButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearEntryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClearEntryButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ClearEntryButton, "ClearEntryButton");
            this.ClearEntryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.UseVisualStyleBackColor = false;
            this.ClearEntryButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.DelButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.DelButton, "DelButton");
            this.DelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelButton.Name = "DelButton";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // InverseButton
            // 
            this.InverseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InverseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.InverseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.InverseButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.InverseButton, "InverseButton");
            this.InverseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InverseButton.Name = "InverseButton";
            this.InverseButton.UseVisualStyleBackColor = false;
            this.InverseButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sqrtButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sqrtButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.sqrtButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.sqrtButton, "sqrtButton");
            this.sqrtButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.UseVisualStyleBackColor = false;
            this.sqrtButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // sqrButton
            // 
            this.sqrButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sqrButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.sqrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.sqrButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.sqrButton, "sqrButton");
            this.sqrButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sqrButton.Name = "sqrButton";
            this.sqrButton.UseVisualStyleBackColor = false;
            this.sqrButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // devideButton
            // 
            this.devideButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.devideButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.devideButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.devideButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.devideButton, "devideButton");
            this.devideButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.devideButton.Name = "devideButton";
            this.devideButton.UseVisualStyleBackColor = false;
            this.devideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // numButton7
            // 
            this.numButton7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton7.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton7.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton7.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton7, "numButton7");
            this.numButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton7.Name = "numButton7";
            this.numButton7.UseVisualStyleBackColor = false;
            this.numButton7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton8
            // 
            this.numButton8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton8.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton8.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton8.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton8, "numButton8");
            this.numButton8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton8.Name = "numButton8";
            this.numButton8.UseVisualStyleBackColor = false;
            this.numButton8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton9
            // 
            this.numButton9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton9.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton9.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton9.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton9, "numButton9");
            this.numButton9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton9.Name = "numButton9";
            this.numButton9.UseVisualStyleBackColor = false;
            this.numButton9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiplyButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.multiplyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.multiplyButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.multiplyButton, "multiplyButton");
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // numButton4
            // 
            this.numButton4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton4.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton4, "numButton4");
            this.numButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton4.Name = "numButton4";
            this.numButton4.UseVisualStyleBackColor = false;
            this.numButton4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton5
            // 
            this.numButton5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton5.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton5, "numButton5");
            this.numButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton5.Name = "numButton5";
            this.numButton5.UseVisualStyleBackColor = false;
            this.numButton5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton6
            // 
            this.numButton6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton6.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton6.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton6, "numButton6");
            this.numButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton6.Name = "numButton6";
            this.numButton6.UseVisualStyleBackColor = false;
            this.numButton6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minusButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.minusButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.minusButton, "minusButton");
            this.minusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minusButton.Name = "minusButton";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // numButton1
            // 
            this.numButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton1, "numButton1");
            this.numButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton1.Name = "numButton1";
            this.numButton1.UseVisualStyleBackColor = false;
            this.numButton1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton2
            // 
            this.numButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton2, "numButton2");
            this.numButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton2.Name = "numButton2";
            this.numButton2.UseVisualStyleBackColor = false;
            this.numButton2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // numButton3
            // 
            this.numButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton3, "numButton3");
            this.numButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton3.Name = "numButton3";
            this.numButton3.UseVisualStyleBackColor = false;
            this.numButton3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlusMinusButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlusMinusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.PlusMinusButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PlusMinusButton, "PlusMinusButton");
            this.PlusMinusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.SpecialOperation_Click);
            // 
            // numButton0
            // 
            this.numButton0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numButton0.Cursor = System.Windows.Forms.Cursors.Default;
            this.numButton0.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.numButton0.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.numButton0, "numButton0");
            this.numButton0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numButton0.Name = "numButton0";
            this.numButton0.UseVisualStyleBackColor = false;
            this.numButton0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decimalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.decimalButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.decimalButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.decimalButton, "decimalButton");
            this.decimalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.DecimalSepratorButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.equalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.equalButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.equalButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.equalButton, "equalButton");
            this.equalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equalButton.Name = "equalButton";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // MemButton1
            // 
            this.MemButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.MemButton1, "MemButton1");
            this.MemButton1.Name = "MemButton1";
            this.MemButton1.UseVisualStyleBackColor = true;
            this.MemButton1.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton2
            // 
            this.MemButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.MemButton2, "MemButton2");
            this.MemButton2.Name = "MemButton2";
            this.MemButton2.UseVisualStyleBackColor = true;
            this.MemButton2.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton3
            // 
            this.MemButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.MemButton3, "MemButton3");
            this.MemButton3.Name = "MemButton3";
            this.MemButton3.UseVisualStyleBackColor = true;
            this.MemButton3.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton4
            // 
            this.MemButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.MemButton4, "MemButton4");
            this.MemButton4.Name = "MemButton4";
            this.MemButton4.UseVisualStyleBackColor = true;
            this.MemButton4.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton5
            // 
            this.MemButton5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.MemButton5, "MemButton5");
            this.MemButton5.Name = "MemButton5";
            this.MemButton5.UseVisualStyleBackColor = true;
            this.MemButton5.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // MemButton6
            // 
            this.MemButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.MemButton6, "MemButton6");
            this.MemButton6.Name = "MemButton6";
            this.MemButton6.UseVisualStyleBackColor = true;
            this.MemButton6.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.menuButton, "menuButton");
            this.menuButton.Name = "menuButton";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.TriggerMenuButton_Click);
            // 
            // numBox
            // 
            this.numBox.BackColor = System.Drawing.SystemColors.Control;
            this.numBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.numBox, "numBox");
            this.numBox.Name = "numBox";
            this.numBox.ReadOnly = true;
            // 
            // calculationBox
            // 
            this.calculationBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calculationBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.calculationBox, "calculationBox");
            this.calculationBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calculationBox.Name = "calculationBox";
            this.calculationBox.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menu
            // 
            this.menu.Controls.Add(this.menuButton2);
            this.menu.Controls.Add(this.menuButton1);
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // menuButton2
            // 
            this.menuButton2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.menuButton2, "menuButton2");
            this.menuButton2.Name = "menuButton2";
            this.menuButton2.UseVisualStyleBackColor = true;
            this.menuButton2.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // menuButton1
            // 
            this.menuButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.menuButton1, "menuButton1");
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.UseVisualStyleBackColor = true;
            this.menuButton1.Click += new System.EventHandler(this.MenuButton_Click);
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
            resources.ApplyResources(this.MemPanel, "MemPanel");
            this.MemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemPanel.Name = "MemPanel";
            // 
            // Standard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemPanel);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.InverseButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.sqrButton);
            this.Controls.Add(this.devideButton);
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
            this.MaximizeBox = false;
            this.Name = "Standard";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumButton_OnKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumButton_OnKeyPress);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button ClearEntryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button InverseButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button sqrButton;
        private System.Windows.Forms.Button devideButton;
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
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Timer triggerMenu;
        private System.Windows.Forms.Timer triggerMemPanel;
        private System.Windows.Forms.Button menuButton1;
        private System.Windows.Forms.Button menuButton2;
        private FlowLayoutPanel MemPanel;
    }
}


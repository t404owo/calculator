using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            Standard standard = new Standard();
            standard.Dock = DockStyle.Fill;
            standard.TopLevel = false;
            this.Controls.Clear();
            this.Controls.Add(standard);
            standard.Show();
            standard.Focus();
        }
    }
}

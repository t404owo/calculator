using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal class Utils
    {
        static public string PrintSubscripts(int value)
        {
            char[] subscript = new char[10] {
                '₀','₁','₂','₃','₄','₅','₆','₇','₈','₉',
            };
            string output = "";

            for (int i = 0; i < value.ToString().Length; i++) output += subscript[int.Parse(value.ToString()[i].ToString())];

            return output;
        }
        static public void FontScale(Control.ControlCollection ctrls, float size)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    FontScale(ctrl.Controls, size);
                
                ctrl.Font = new Font(ctrl.Font.FontFamily, (float)(ctrl.Font.Size*size), ctrl.Font.Style, ctrl.Font.Unit, ctrl.Font.GdiCharSet);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculation
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        public Boolean IsEnableOtomatikComma()
        {
            return isEnableOtomatikComma;
        }

        private Boolean isEnableOtomatikComma = false;

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                CalculatorUI.options.isEnableOtomatikComma = true;
            }
            else
            {
                CalculatorUI.options.isEnableOtomatikComma = false;
            }
        }
    }
}

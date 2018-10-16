using System;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                CalculatorUI.options.isEnableOtomatikComma = true;
                BaseClass.calculatorUI.RewriteResultScreen();
            }
            else
            {
                CalculatorUI.options.isEnableOtomatikComma = false;
                BaseClass.calculatorUI.RewriteResultScreen();
            }
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            BaseClass.calculatorUI.OptionsButton_Click(sender,e);
        }
    }
}

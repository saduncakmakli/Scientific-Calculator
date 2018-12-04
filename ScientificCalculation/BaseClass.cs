using System;
using System.Windows.Forms;

namespace ScientificCalculation
{
    internal class BaseClass
    {
        internal BaseClass()
        {
            Application.Run(calculatorUI);
        }

        internal static CalculatorUI calculatorUI = new CalculatorUI();
    }
}

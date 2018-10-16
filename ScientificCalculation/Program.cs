using System;
using System.Windows.Forms;

namespace ScientificCalculation
{

    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BaseClass runnableDebugClass = new BaseClass();
        }
        
    }
    
}

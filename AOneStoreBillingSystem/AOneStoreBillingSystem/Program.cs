using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOneStoreBillingSystem
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
            if(!IsAnotherProcessRunning())
            {
                Application.Run(new HomePage());
            }
            else
            {
                MessageBox.Show("Another Instance Of This Application Running");
                Application.Exit();
            }
        }

        private static bool IsAnotherProcessRunning()
        {
            Process[] process = Process.GetProcessesByName("AOneStoreBillingSystem");
            if(process.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}

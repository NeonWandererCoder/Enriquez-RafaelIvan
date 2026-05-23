using System;
using System.Windows.Forms;

namespace CashierApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the application with the login form
            Application.Run(new frmLoginAccount());
        }
    }
}

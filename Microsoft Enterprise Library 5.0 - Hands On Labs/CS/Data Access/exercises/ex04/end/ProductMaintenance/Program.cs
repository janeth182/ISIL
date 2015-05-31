using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductMaintenance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            switch (MessageBox.Show("Press Retry to re-throw: \n" + e.Exception.ToString(), "Unhandled Exception", MessageBoxButtons.AbortRetryIgnore))
            {
                case DialogResult.Abort:
                    Application.Exit();
                    break;

                case DialogResult.Retry:
                    throw new Exception("Exception re-throw", e.Exception);
            }
        }
    }
}
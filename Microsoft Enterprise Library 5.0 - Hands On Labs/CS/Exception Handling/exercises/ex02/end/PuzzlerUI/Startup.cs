using System;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace PuzzlerUI
{
    class Startup
    {
        [STAThread]
        static void Main()
        {
            // Handle unhandled exceptions
            Application.ThreadException +=
                new ThreadExceptionEventHandler(Application_ThreadException);

            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Puzzler f = new Puzzler();
            Application.Run(f);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is System.Exception)
            {
                HandleException((System.Exception)e.ExceptionObject, "Unhandled Policy");
            }
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception, "UI Policy");
        }

        public static void HandleException(Exception ex, string policy)
        {
            Boolean rethrow = false;
            try
            {
							var exManager = EnterpriseLibraryContainer.Current.GetInstance<ExceptionManager>();
							rethrow = exManager.HandleException(ex, policy);
            }
            catch (Exception innerEx)
            {
                string errorMsg = "An unexpected exception occured while " +
                    "calling HandleException with policy '" + policy + "'. ";
                errorMsg += Environment.NewLine + innerEx.ToString();

                MessageBox.Show(errorMsg, "Application Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                throw ex;
            }

            if (rethrow)
            {
                // WARNING: This will truncate the stack of the exception
                throw ex;
            }
            else
            {
                MessageBox.Show("An unhandled exception occurred and has " +
                    "been logged. Please contact support.");
            }
        }
    }
}

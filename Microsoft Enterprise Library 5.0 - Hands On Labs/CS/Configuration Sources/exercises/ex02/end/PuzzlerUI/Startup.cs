using System;
using System.Security.Policy;
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
            //calling appliation.run blocks execution.
            //therefore we run the first application on a sepperate thread, 
            //have execution block on the second app.
            ThreadPool.QueueUserWorkItem(unused =>
            {
                var puzzlerApplicationDomainSetup1 = new AppDomainSetup { ConfigurationFile = "puzzler1.config" };
                var puzzlerApplicationDomain1 = AppDomain.CreateDomain("Puzzler1", new Evidence(AppDomain.CurrentDomain.Evidence), puzzlerApplicationDomainSetup1);
                var application1 = (ApplicationHost)puzzlerApplicationDomain1.CreateInstanceAndUnwrap("PuzzlerUI", "PuzzlerUI.ApplicationHost");

                application1.Run();
            });

            var puzzlerApplicationDomainSetup2 = new AppDomainSetup { ConfigurationFile = "puzzler2.config" };
            var puzzlerApplicationDomain2 = AppDomain.CreateDomain("Puzzler2", new Evidence(AppDomain.CurrentDomain.Evidence), puzzlerApplicationDomainSetup2);
            var application2 = (ApplicationHost)puzzlerApplicationDomain2.CreateInstanceAndUnwrap("PuzzlerUI", "PuzzlerUI.ApplicationHost");
            application2.Run();

        }
    }

    public class ApplicationHost : MarshalByRefObject
    {
        public ApplicationHost()
        {

            // Handle unhandled exceptions
            Application.ThreadException +=
                new ThreadExceptionEventHandler(Application_ThreadException);

            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        public void Run()
        {
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


            MessageBox.Show("An Exception has ocurred and has " +
                "been logged. Please contact support." +
                string.Format("\n\n- Exception Type: {0}", ex.GetType().Name) +
                string.Format("\n\n- Exception Message: {0}", ex.Message) +
                (rethrow ? "\n\n- Exception Policy was configured to retrow this exception" : ""));

            //if (rethrow)
            //{
            //    // WARNING: This will truncate the stack of the exception
            //    throw ex;
            //}
        }
    }
}

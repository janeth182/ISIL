using System;
using System.Configuration;
using System.Windows.Forms;
using System.Text;
using EnoughPI.Logging;
// TODO: Use Enterprise Library Logging
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace EnoughPI.Calc
{
	public class Calculator
    {
 				private LogWriter writer = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
				private TraceManager traceMgr = EnterpriseLibraryContainer.Current.GetInstance<TraceManager>();

        public event CalculatedEventHandler Calculated;
        public event CalculatingEventHandler Calculating;
        public event CalculatorExceptionEventHandler CalculatorException;
        
        private delegate string CalculateDelegate(int digits);
        private CalculateDelegate dlg;

        public IAsyncResult BeginCalculate(int digits, AsyncCallback callback) 
        {
            dlg = new CalculateDelegate(this.Calculate);
            return dlg.BeginInvoke(digits, callback, this);
        }
        
        public IAsyncResult BeginCalculate(int digits) 
        {
            dlg = new CalculateDelegate(this.Calculate);
            AsyncCallback callback = new AsyncCallback(this.CalculateCallback);
            return dlg.BeginInvoke(digits, callback, dlg);
        }

        private void CalculateCallback(IAsyncResult ar)
        {
            CalculateDelegate dlg = (CalculateDelegate) ar.AsyncState;
            dlg.EndInvoke(ar);
        }

        public string EndCalculate(IAsyncResult ar)
        {
            return dlg.EndInvoke(ar);
        }

        public string Calculate(int digits)
        {
            StringBuilder pi = new StringBuilder("3", digits + 2);
            string result = null;

            try
            {
                if (digits > 0)
                {
                    // TODO: Add Tracing around the calculation
                    using (Tracer trace = traceMgr.StartTrace(Category.Trace))
                    {
                        pi.Append(".");
                        for (int i = 0; i < digits; i += 9)
                        {
                            CalculatingEventArgs args;
                            args = new CalculatingEventArgs(pi.ToString(), i + 1);
                            OnCalculating(args);

                            // Break out if cancelled
                            if (args.Cancel == true) break;

                            // Calculate next 9 digits
                            int nineDigits = NineDigitsOfPi.StartingAt(i + 1);
                            int digitCount = Math.Min(digits - i, 9);
                            string ds = string.Format("{0:D9}", nineDigits);
                            pi.Append(ds.Substring(0, digitCount));
                        }
                    }
                }

                result = pi.ToString();

                // Tell the world I've finished!
                OnCalculated(new CalculatedEventArgs(result));
            }
            catch (Exception ex)
            {
                // Tell the world I've crashed!
                OnCalculatorException(new CalculatorExceptionEventArgs(ex));
            }

            return result;
        }

        protected void OnCalculated(CalculatedEventArgs args)
        {
            // TODO: Log final result
            LogEntry log = new LogEntry();
            log.Message = string.Format("Calculated PI to {0} digits", args.Digits);
            log.Categories.Add(Category.General);
            log.Priority = Priority.Normal;

						writer.Write(log);

            if (Calculated != null)
                Calculated(this, args);
        }

        protected void OnCalculating(CalculatingEventArgs args)
        {
            // TODO: Log progress
					writer.Write(
                string.Format("Calculating next 9 digits from {0}", args.StartingAt),
                Category.General,
                Priority.Low
                );

            if (Calculating != null)
                Calculating(this, args);

            if (args.Cancel == true)
            {
                // TODO: Log cancellation
							writer.Write("Calculation cancelled by user!",
                    Category.General, Priority.High);
            }
        }

        protected void OnCalculatorException(CalculatorExceptionEventArgs args)
        {
            // TODO: Log exception
            if (!(args.Exception is ConfigurationErrorsException))
            {
							writer.Write(args.Exception, Category.General, Priority.High);
            }

            if (CalculatorException != null)
                CalculatorException(this, args);
        }
    }
}

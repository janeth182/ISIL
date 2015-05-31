using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

using StocksTicker.Loggers;
using StocksTicker.StockQuoteServices;
using StocksTicker.UI;

namespace StocksTicker
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

            using (IUnityContainer container = new UnityContainer())
            {
                container
                    .RegisterType<IStocksTickerView, StocksTickerForm>()
                    .RegisterType<IStockQuoteService, MoneyCentralStockQuoteService>()
                    .RegisterType<ILogger, ConsoleLogger>()
                    .RegisterType<ILogger, TraceSourceLogger>("UI")
                    .RegisterInstance(new TraceSource("UI", SourceLevels.All));

                StocksTickerPresenter presenter
                    = container.Resolve<StocksTickerPresenter>();

                Application.Run((Form)presenter.View);
            }
        }
    }
}
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
                // TODO replace with application of configuration information here
                container
                    .RegisterType<IStocksTickerView, StocksTickerForm>()
                    .RegisterType<IStockQuoteService, MoneyCentralStockQuoteService>(
                        new InjectionProperty("Logger"))
                    .RegisterType<ILogger, ConsoleLogger>()
                    .RegisterType<ILogger, TraceSourceLogger>(
                        "UI",
                        new ContainerControlledLifetimeManager(),
                        new InjectionConstructor("UI"))
                    .RegisterType<StocksTickerPresenter>(
                        new InjectionProperty(
                            "Logger",
                            new ResolvedParameter<ILogger>("UI")));

                StocksTickerPresenter presenter
                    = container.Resolve<StocksTickerPresenter>();

                Application.Run((Form)presenter.View);
            }
        }
    }
}
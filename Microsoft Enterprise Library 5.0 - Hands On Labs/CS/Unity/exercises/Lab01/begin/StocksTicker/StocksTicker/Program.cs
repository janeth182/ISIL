using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

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

            // TODO use a container to create the objects here
            StocksTickerForm view = new StocksTickerForm();
            MoneyCentralStockQuoteService service = new MoneyCentralStockQuoteService();
            service.Logger = new ConsoleLogger();
            StocksTickerPresenter presenter
                = new StocksTickerPresenter(view, service);
            presenter.Logger = new TraceSourceLogger("UI");

            Application.Run((Form)presenter.View);
        }
    }
}
using System.Collections.Generic;

namespace StocksTicker.StockQuoteServices
{
    public interface IStockQuoteService
    {
        IDictionary<string, StockQuote> GetQuotes(IEnumerable<string> symbol);
    }
}

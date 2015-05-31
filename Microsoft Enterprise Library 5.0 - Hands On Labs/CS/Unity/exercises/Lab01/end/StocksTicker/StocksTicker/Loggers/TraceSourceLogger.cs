using System.Diagnostics;
using Microsoft.Practices.Unity;

namespace StocksTicker.Loggers
{
    public class TraceSourceLogger : ILogger
    {
        private TraceSource traceSource;

        public TraceSourceLogger(string traceSourceName)
            : this(new TraceSource(traceSourceName, SourceLevels.All))
        {
        }

        [InjectionConstructor]
        public TraceSourceLogger(TraceSource traceSource)
        {
            this.traceSource = traceSource;
        }

        public void Log(string message, TraceEventType eventType)
        {
            this.traceSource.TraceEvent(eventType, 0, message);
            this.traceSource.Flush();
        }
    }
}

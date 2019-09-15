using Serilog;
using Serilog.Events;

namespace Skork.Logging
{
    public class SkorkLog
    {
        static SkorkLog()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}

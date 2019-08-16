using Serilog;
using Serilog.Events;

namespace Skork_Engine_Library.Debug {
    public class SkorkDebug {

        static SkorkDebug() {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
        }

        
    }
}

using Serilog;

public static class LoggerConfig
{
    public static void configure()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
    }
}

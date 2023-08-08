using DocnetCorePractice;
using Serilog;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        _ = builder.Host.UseSerilog((hostContext, loggerConfiguration) =>
           _ = loggerConfiguration.ReadFrom.Configuration(builder.Configuration));

        var startup = new Startup(builder, builder.Environment);
        startup.ConfigureServices(builder.Services);

        var app = builder.Build();
        startup.Configure(app, builder.Environment);
        app.Run();
    }
}
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

using TextFilterUtilities;

using TFUS = TextFilterUtilities.Services;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IApplication, Application>();
                    services.AddSingleton<IFilter1, Filter1>();
                    services.AddSingleton<IFilter2, Filter2>();
                    services.AddSingleton<IFilter3, Filter3>();
                    services.AddSingleton<ITextFilter, TFUS.TextFilter>();
                })
                .UseSerilog()
                .Build();

            var service = ActivatorUtilities.CreateInstance<Application>(host.Services);
            service.Run();
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("CALASTONE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}
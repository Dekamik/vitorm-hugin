using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Vitorm.Hugin.Console
{
    public static class Program
    {
        private static IServiceProvider _serviceProvider;
        
        private static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .CreateLogger();
            
            RegisterServices();
            try
            {
                var scope = _serviceProvider.CreateScope();
                scope.ServiceProvider.GetRequiredService<ConsoleApplication>().Run();
            }
            finally
            {
                DisposeServices();
            }
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddLogging(builder => builder.AddSerilog(Log.Logger, true));
            services.AddSingleton<ConsoleApplication>();

            _serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            if (_serviceProvider is IDisposable disposable)
                disposable.Dispose();
        }
    }
}
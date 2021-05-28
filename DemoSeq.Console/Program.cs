using DemoSeq.Application;
using DemoSeq.Domain;
using DemoSeq.Infra.Seq;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSeq.ConsoleApp
{
    public class Program
    {
        private static ServiceProvider _serviceProvider;

        public static void Main()
        {
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            _ = scope.ServiceProvider.GetRequiredService<ConsoleApplication>().RunAsync();
            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<ConsoleApplication>();

            services.AddTransient<ILogRepository, LogRepository>();
            services.AddTransient<ILogAppService, LogAppService>();

            _serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}

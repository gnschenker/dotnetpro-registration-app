using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NServiceBus;

namespace applications_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseNServiceBus(context =>
                {
                    var endpointConfiguration = new EndpointConfiguration("Applications.API");
                    var transport = endpointConfiguration.UseTransport<LearningTransport>();
                    return endpointConfiguration;
                });
    }
}

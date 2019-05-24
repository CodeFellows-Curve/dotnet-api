using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using curve_api.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace curve_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args).Build();

            using (IServiceScope scope = host.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;

                // LEGACY CODE DO NOT USE
                // LEGACY CODE DO NOT USE
                // LEGACY CODE DO NOT USE

                //try
                //{
                //    StartupDbInitializer.SeedData(services);
                //}

                //catch (Exception e)
                //{
                //    ILogger logger = host.Services.GetRequiredService<ILogger<Program>>();
                //    logger.LogInformation(e.ToString());
                //}

                host.Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(logging => 
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                });
    }
}

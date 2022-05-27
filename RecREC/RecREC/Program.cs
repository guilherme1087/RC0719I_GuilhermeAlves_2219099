using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace RecREC
{
    public class Program
    {
        public static void Main(string[] args)
        {
             CreateHostBuilder(args).ConfigureAppConfiguration((hostingContext, config) =>
             {
                    config.AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true); 
            }).Build().Run();
            }
    }
}

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
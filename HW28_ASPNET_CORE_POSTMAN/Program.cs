using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW28_ASPNET_CORE_POSTMAN.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HW28_ASPNET_CORE_POSTMAN
{
    public class Program
    {   

        public static void Main(string[] args)
        {

           var host =  CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope()) 
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<DataContext>();

                    context.Database.Migrate();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

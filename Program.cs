using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("hosting.json", optional: true)
                .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
//                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseConfiguration(configuration)
                .Build();

            host.Run();
        }
    }
}

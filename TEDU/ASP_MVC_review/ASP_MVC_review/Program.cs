using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ASP_MVC_review
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
           // Console.WriteLine("Hello bao");
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            //-----System code
            //return WebHost.CreateDefaultBuilder(args)
            //               .UseStartup<Startup>();

            //-----Explantion code
            var builder = new WebHostBuilder().w;

            
        }
           
    }
}

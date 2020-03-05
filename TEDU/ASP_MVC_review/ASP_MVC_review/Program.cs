using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            return WebHost.CreateDefaultBuilder(args)
                           .UseStartup<Startup>();

            //-----Explantion code: this use the chainable method ( method chaining )
            //var builder = new WebHostBuilder() // this is builder design pattern 
            //                    .UseKestrel() // server use for this webhost is Kestrel
            //                    .UseStartup<Startup>()  // specify class startup for host
            //                    .UseContentRoot(Directory.GetCurrentDirectory()) // specify the root folder of this application
            //                    .ConfigureAppConfiguration((hostingContext,config)=>{

            //                        var env = hostingContext.HostingEnvironment; // get env name
            //                        // AddJsonFile (which file config this app will receive) | optional: true => if don't see file config, it will not show error | reloadONchange: auto recieve new config if there is something change, if no change -> dun need to restart app
            //                        config.AddJsonFile("appsetting.json",optional: true, reloadOnChange:true)
            //                                .AddJsonFile($"appsetting.{env.EnvironmentName}.json",optional: true, reloadOnChange:true); // add setting dev env

            //                        if(env.IsDevelopment()){
            //                            //this is assembly file of this app(when this project built ->ASP_MVC_Review.dll)
            //                            var appAssembly= Assembly.Load(new AssemblyName(env.ApplicationName)); // load current assembly file
            //                            if(appAssembly != null){
            //                                config.AddUserSecrets(appAssembly,optional: true);
            //                            }
            //                        }

            //                        //get system Environment valuable: tham so he thong trong window
            //                        config.AddEnvironmentVariables();
            //                        if( args != null){
            //                            config.AddCommandLine(args);
            //                        }

            //                    }) // done config app
            //                    .ConfigureLogging((hostingContext, logging)=>{ // config logging
            //                        logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging")); // in section Logging in appsetting.json
            //                        logging.AddConsole(); // write logging on console screen
            //                        logging.AddDebug(); // write logging in debug screen 
            //                    })
            //                    //use this app on IIS to collaborate with Kestrel
            //                    .UseIISIntegration()
            //                    .UseDefaultServiceProvider((context,options)=>{
            //                        options.ValidateScopes= context.HostingEnvironment.IsDevelopment(); // use for env dev
            //                    });
            //                    return builder;
        }
           
    }
}

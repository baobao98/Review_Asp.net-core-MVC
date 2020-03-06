using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConfigurationSample
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // --The orders to add appsetting:
            // privilege for use secrect
            // depend on the env the config get when building host, app will take appsetting according to the name of environment
            // dev env -> get appsettings.Development.json
            // dev production -> get appsettings.Production.json
            app.Run(async context =>
            { 
                await context.Response.WriteAsync(Configuration.GetSection("Message").Value); // Hello from Configuration 
                // read child value 
                await context.Response.WriteAsync(Configuration.GetSection("ConnectionStrings:SQLServerConnectionString").Value);// SQL Connection string sample
                // read array
                await context.Response.WriteAsync(Configuration.GetSection("Students:0:Name").Value); // Student A
            });

        }
    }
}

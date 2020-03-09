﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DemoMVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); // app will use mvc model
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();

            //---constrain by routes in config
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(name: "default",
            //                    template: "post/{id:int}",
            //                    defaults: new { controller = "Post", action = "PostsByID" });

            //    routes.MapRoute(name: "anotherRoute",
            //        template: "post/{id:alpha}",
            //        defaults: new { controller = "Post", action = "PostsByPostName" });

            //});

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Fail to call action");
            });


        }
    }
}

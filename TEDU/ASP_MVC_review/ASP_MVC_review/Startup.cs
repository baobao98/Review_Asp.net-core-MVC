using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ASP_MVC_review.Middlewares;
using ASP_MVC_review.Extensions;

namespace ASP_MVC_review
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //app.UseStaticFiles();
            //app.UseCookiePolicy();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});



            // ------- There are 2 ways to add middleware: use app.run (terminal middleware) or app.use
            //Middleware will follow the orders
            //Middleware go up to down and go down to up again => middleware invoked twice

            //--below is inline middleware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<div> Hello world from Middleware 1 </div>");
                await next.Invoke(); // call next middleware
                await context.Response.WriteAsync("<div> Returning form the Middleware 1 </div>");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<div> Hello world from Middleware 2 </div>");
                await next.Invoke();
                await context.Response.WriteAsync("Returning from the Middleware 2 <br>");
            });

            // --normal way to evoke a middlware
            //app.UseMiddleware<SimpleMiddleware>();
            // --extension way to evoke a middlware
            app.Use_SimpleMiddlware();


            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello world from Middleware 3 <br>");
            });


        }
    }
}

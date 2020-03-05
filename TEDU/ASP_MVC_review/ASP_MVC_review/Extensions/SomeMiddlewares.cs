using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_MVC_review.Middlewares;
using Microsoft.AspNetCore.Http;

namespace ASP_MVC_review.Extensions
{
    public static class SomeMiddlewares
    {
        public static IApplicationBuilder Use_SimpleMiddlware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SimpleMiddleware>();
        }

        public static void HandleMapTest(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from MAP middlware");
            });
        }
    }

}

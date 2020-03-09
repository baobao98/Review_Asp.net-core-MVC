using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    //we will not inheritance from class Controller
    public class UnderstandController 
    {
        //inject HttpContext
        HttpContext ctx;

        public UnderstandController(IHttpContextAccessor _ctx)
        {
            ctx = _ctx.HttpContext;
        }

        public async void Index()
        {
            //set status code
            ctx.Response.StatusCode = 200;
            //set content type 
            ctx.Response.ContentType = "text/html";
            //create response
            ctx.Response.Headers.Add("SomeHeader", "Value");
            byte[] content = Encoding.ASCII.GetBytes("<html><body>Hello from understand controller</body></html>");
            //send it to client
            await ctx.Response.Body.WriteAsync(content, 0, content.Length);

        }
    }
}
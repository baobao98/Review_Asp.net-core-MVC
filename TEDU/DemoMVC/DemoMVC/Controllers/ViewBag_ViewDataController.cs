using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class ViewBag_ViewDataController : Controller
    {
        [Route("viewdata")]
        public IActionResult Index()
        {
            //using view data
            ViewData["Greeting"] = "Hello World from view data";
            ViewData["Product"] = new ProductModel() {id=1,Name="Product 1",Available=true,Price=10000,PromotionPrice=90000};

            //using view bag
            ViewBag.greeting = "Hello world from view bag";
            ViewBag.product= new ProductModel() {id=1,Name="Product 100",Available=true,Price=10000,PromotionPrice=90000};

            return View();
        }
    }
}
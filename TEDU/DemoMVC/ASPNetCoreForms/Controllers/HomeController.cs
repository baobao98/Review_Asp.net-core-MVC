using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNetCoreForms.Models;

namespace ASPNetCoreForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                //Check name
                if (model.Name == "bao")
                {
                    ModelState.AddModelError("", "This name existed");
                    return View(model);
                }
                message = "Product" + model.Name + ". Rate: " + model.Rate + ". Rating: " + model.Rating + " successfully";
            }
            else
            {
                return View(model);
            }
            return Content(message);
        }
    }
}
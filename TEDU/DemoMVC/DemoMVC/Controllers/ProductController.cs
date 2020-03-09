using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Normal(map url with action): localhost:6000/product/edit
        //but we can rename to map by using ActionName or Route() ( 2 methods could use at the same time)
        [ActionName("modify")]
        [Route("Product/modify")]
        public IActionResult Edit()
        {
            return View();
        }

        //mark this don't use as action to return view by using NonAction
        [NonAction]
        public string Edit2()
        {
            return "hello from edit2";
        }
        
        //Similar action name but different param and type
        [HttpGet("{id}")] 
        public string Edit3(string id)
        {
            return "hello from edit3";
        }
        [HttpPost]
        public IActionResult Edit3(ProductModel model)
        {
            return RedirectToAction("Index", "Product");
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody]ProductModel product)
        {
            return Ok();
        }
    }
}
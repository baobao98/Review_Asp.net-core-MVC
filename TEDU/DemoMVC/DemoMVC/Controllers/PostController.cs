using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PostController : Controller
    {
        [Route("post/index/{id:int}")]
        public IActionResult PostsByID(int id)
        {
            return View();
        }
        [Route("post/index/{id:alpha}")]
        public IActionResult PostsByPostName(string id)
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    [Route("test")]
    public class CustomerController : Controller
    {
        [Route("customer")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("khach-hang/vip")]
        public string khachhang()
        {
            return "xin chao khach hang vip";
        }

    }
}
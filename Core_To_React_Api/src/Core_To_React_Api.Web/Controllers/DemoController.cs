using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_To_React_Api.Web.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            string str = "Rajesh Change";
            return View();
        }
    }
}

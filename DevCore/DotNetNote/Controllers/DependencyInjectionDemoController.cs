using Microsoft.AspNetCore.Mvc;
using System;

namespace DotNetNote.Controllers
{
    public class DependencyInjectionDemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Copyright = $"Copyright {DateTime.Now.Year} all right reserved.";

            return View();
        }

        public IActionResult AtInjectionDemo()
        {
            return View();
        }
    }
}

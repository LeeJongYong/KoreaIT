using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class VIewComponentDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CopyrightDemo()
        {
            return View();
        }

        public IActionResult TechListDemo() { return View(); }
    }
}

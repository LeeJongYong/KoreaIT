using Microsoft.AspNetCore.Mvc;
using System;

namespace DotNetNote.Controllers
{
    public class ViewBagDemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "우투리";
            ViewBag.age = "32";
            ViewBag.블라블라 = "blaaaaa~~";

            ViewData["address"] = "양재역";

            return View();
        }
    }
}

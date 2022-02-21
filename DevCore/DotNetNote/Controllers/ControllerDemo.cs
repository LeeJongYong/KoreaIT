using Microsoft.AspNetCore.Mvc;
using System;

namespace DotNetNote.Controllers
{
    public class ControllerDemo : Controller
    {
        public void Index()
        {

        }

        public string StringAction()
        {
            return "String 반환 액션 메서드";
        }

        public DateTime DateTimeAction()
        {
            return DateTime.Now;
        }

        public IActionResult DefaultAction()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using DotNetNote.Models;

namespace DotNetNote.Controllers
{
    public class FormValidationDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Html()
        {
            return View();
        }

        public IActionResult HtmlProcess(string txtName, string txtContent)
        {
            ViewBag.resultString = $"이름 : {txtName}, 내용 : {txtContent}";
            return View();
        }

        [HttpGet]
        public IActionResult HelperMethod()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelperMethod(string txtName, string txtContent)
        {
            ViewBag.resultString = $"이름 : {txtName}, 내용 : {txtContent}";
            return View();   
        }

        public IActionResult StronglyTypeView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StronglyTypeView(MaximModel maxim)
        {
            return View();
        }

        public IActionResult ModelValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelValidation(MaximModel maxim)
        {
            if (string.IsNullOrEmpty(maxim.Name))
            {
                ModelState.AddModelError("Name", "이름을 입력하시죠");
            }
            if (string.IsNullOrEmpty(maxim.Content))
            {
                ModelState.AddModelError("Content", "내용을 입력하시죠");
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "모든 에러");
            }

            if (ModelState.IsValid)
            {
                return View("Completed");
            }

            return View();
        }

        public IActionResult Completed()
        {
            return View();
        }

        public IActionResult ClientValidation()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult ClientValidation(MaximModel maxim)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            return View();
        }
    }
}

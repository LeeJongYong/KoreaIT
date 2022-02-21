using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            // 모든 데이터를 View 페이지에 전달
            DataService dService = new DataService();
            var data = dService.GetAll();
            return View(data);
        }
    }
}

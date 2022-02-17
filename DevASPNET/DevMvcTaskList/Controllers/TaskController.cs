using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevMvcTaskList.Models;

namespace DevMvcTaskList.Controllers
{
    public class TaskController : Controller
    {
        private TaskRepository repo = new TaskRepository();
        // GET: Task
        public ActionResult Index()
        {
            var r = repo.getTasks();

            return View(r);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProcess(string title)
        {
            repo.addTask(new TaskModel { Title = title });
            return RedirectToAction("Index");
        }

        public ActionResult Complete(int id)
        {
            repo.completeTask(id);
            return RedirectToAction("Index");
        }
    }
}
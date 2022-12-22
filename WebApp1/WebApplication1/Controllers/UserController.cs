using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly DbTasks context;
        static private List<Tasks> sort = new List<Tasks> { };       
        public UserController(DbTasks context)
        {
            this.context = context;
        }

        //context.SaveCha
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserM()
        {
            return View(context.Tasks.ToList());
        }
        public IActionResult NewTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tasks o)
        {
            if (!ModelState.IsValid) return View("NewTask");

            context.Tasks.Add(o);
            context.SaveChanges();
            return RedirectToAction("UserM");
        }
        public IActionResult Delete(int? Id)
        {
            if (Id == null) return NotFound();
            var task = context.Tasks.Find(Id);
            if (task == null) return NotFound();
            context.Tasks.Remove(task);
            context.SaveChanges();
            return RedirectToAction("UserM");
        }
        public IActionResult Ready(int Id)
        {
            var task = context.Tasks.Find(Id);
            if (task == null) return NotFound();
            context.Tasks.Find(Id).Status = "Ready";
            context.Tasks.Find(Id).Priority = "";
            context.SaveChanges();
            return RedirectToAction("UserM");
        }
        public IActionResult Sort()
        {
            return View(sort);
        }
        public IActionResult SortPriority(string id)
        {
            if (string.IsNullOrEmpty(id)) return RedirectToAction("Sort");
            sort = context.Tasks.Where(s => s.Priority == id).ToList();
            
            return RedirectToAction("Sort", sort);
        }
        public IActionResult SortStatus(string id)
        {
            if (string.IsNullOrEmpty(id)) return RedirectToAction("Sort");
            sort = context.Tasks.Where(s => s.Status == id).ToList();

            return RedirectToAction("Sort", sort);
        }
       // public IActionResult SortDateEnd(DateTime id)
        //{
            //if (string.IsNullOrEmpty(id)) return RedirectToAction("Sort");
         //   sort = context.Tasks.Where(s => s.EndTime <= id).ToList();

          //  return RedirectToAction("Sort", sort);
        //}
    }
}

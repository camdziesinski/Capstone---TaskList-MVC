using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskList.Models;

namespace TaskList.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        private readonly TaskListDbContext _context;
        public TasksController(TaskListDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            List<Tasks> ThisUserTasks = _context.Tasks.Where(x => x.EmployeeId == id).ToList();
            return View(ThisUserTasks);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Tasks newTask)
        {
            newTask.EmployeeId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (ModelState.IsValid)
            {
                _context.Tasks.Add(newTask);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult ChangeStatus(int id)
        {
            Tasks found = _context.Tasks.Find(id);
            if (found != null)
            {
                //Change the things!
                found.Completed = !found.Completed;
                //modify the state of this entry in the database
                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTask(int id)
        {
            Tasks Found = _context.Tasks.Find(id);
            if (Found != null)
            {
                _context.Tasks.Remove(Found);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GCTechnicalChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace GCTechnicalChallenge.Controllers
{
    public class TaskListController : Controller
    {
        private readonly ToDoListContext _context;

        public TaskListController(ToDoListContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ViewTasks(string orderBy)
        {
            ViewData["DateSortParameter"] = string.IsNullOrEmpty(orderBy) ? "DueDate_Descending" : "";
            ViewData["StatusSortParameter"] = orderBy == "Status_Ascending" ? "Status_Descending" : "Status_Ascending";
            IQueryable<Tasks> tasks = _context.Tasks;

            switch (orderBy)
            {
                case "DueDate_Descending":
                    tasks = tasks.OrderByDescending(task => task.DueDate);
                    break;
                case "Status_Ascending":
                    tasks = tasks.OrderBy(task => task.IsComplete);
                    break;
                case "Status_Descending":
                    tasks = tasks.OrderByDescending(task => task.IsComplete);
                    break;
                default:
                    tasks = tasks.OrderBy(task => task.DueDate);
                    break;
            }

            return View(await tasks.ToListAsync());
        }


        [HttpPost]
        public IActionResult AddTask(Tasks task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();
            }

            return RedirectToAction("ViewTasks");
        }

        public IActionResult UpdateCompletionStatus(int id)
        {
            Tasks task = _context.Tasks.Find(id);
            task.IsComplete = !task.IsComplete;

            _context.Tasks.Update(task);
            _context.SaveChanges();

            return RedirectToAction("ViewTasks");
        }

        public IActionResult RemoveTask(int id)
        {
            Tasks task = _context.Tasks.Find(id);

            _context.Tasks.Remove(task);
            _context.SaveChanges();

            return RedirectToAction("ViewTasks");
        }

        public IActionResult SearchTasks(string query)
        {
            IEnumerable<Tasks> matchingTasks = _context.Tasks.Where(task => task.Description.Contains(query));

            ViewBag.Query = query;

            return View(matchingTasks.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class TaskManagerController : Controller
    {
        private readonly TaskManagerContext context;

        public TaskManagerController(TaskManagerContext context)
        {
            this.context = context;
        }

        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : ""; 
            ViewBag.DateSortParm = sortOrder == "date" ? "date_desc" : "date";
            var tasks = from TaskUnit in context.TaskUnit
                           select TaskUnit;
            switch (sortOrder)
            {
                case "name_desc":
                    tasks = tasks.OrderByDescending(TaskUnit => TaskUnit.Name);
                    break;
                case "date":
                    tasks = tasks.OrderBy(TaskUnit => TaskUnit.TimeCreated);
                    break;
                case "date_desc":
                    tasks = tasks.OrderByDescending(TaskUnit => TaskUnit.TimeCreated);
                    break;
                default:
                    tasks = tasks.OrderBy(TaskUnit => TaskUnit.Name);
                    break;
            }
            return View(tasks.ToList());
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskUnit = await this.context.TaskUnit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskUnit == null)
            {
                return NotFound();
            }

            return View(taskUnit);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Content,tag,TimeCreated,TimeElapsed")] TaskUnit taskUnit)
        {
            if (ModelState.IsValid)
            {  
                this.context.Add(taskUnit);
                await this.context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskUnit);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskUnit = await this.context.TaskUnit.FindAsync(id); 
            if (taskUnit == null)
            {
                return NotFound();
            }
            return View(taskUnit);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Content,tag,TimeCreated,TimeElapsed")] TaskUnit taskUnit)
        {
            if (id != taskUnit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this.context.Update(taskUnit);
                    await this.context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskUnitExists(taskUnit.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(taskUnit);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskUnit = await this.context.TaskUnit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taskUnit == null)
            {
                return NotFound();
            }

            return View(taskUnit);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var taskUnit = await this.context.TaskUnit.FindAsync(id);
            this.context.TaskUnit.Remove(taskUnit);
            await this.context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskUnitExists(string id)
        {
            return this.context.TaskUnit.Any(e => e.Id == id);
        }
    }
}

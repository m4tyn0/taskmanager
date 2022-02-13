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

        public async Task<IActionResult> Index()
        {
             return View(await this.context.TaskUnit.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("Id,Name,Content,tag")] TaskUnit taskUnit)
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
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Content,tag")] TaskUnit taskUnit)
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

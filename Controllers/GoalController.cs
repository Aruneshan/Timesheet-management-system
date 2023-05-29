using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TimeMate.Areas.Identity.Data;
using TimeMate.Models;

namespace TimeMate.Controllers
{
    [AllowAnonymous]
    public class GoalController : Controller
    {
        private readonly TimeMateContext _context;

        public GoalController(TimeMateContext context)
        {
            _context = context;
        }

        // GET: Goal
        public async Task<IActionResult> Index()
        {
              return _context.GoalSetting != null ? 
                          View(await _context.GoalSetting.ToListAsync()) :
                          Problem("Entity set 'TimeMateContext.GoalSetting'  is null.");
        }

        // GET: Goal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GoalSetting == null)
            {
                return NotFound();
            }

            var goalSetting = await _context.GoalSetting
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goalSetting == null)
            {
                return NotFound();
            }

            return View(goalSetting);
        }

        // GET: Goal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Goal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,DueDate,IsComplete,AssignedTo,AssignedBy")] GoalSetting goalSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goalSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goalSetting);
        }

        // GET: Goal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GoalSetting == null)
            {
                return NotFound();
            }

            var goalSetting = await _context.GoalSetting.FindAsync(id);
            if (goalSetting == null)
            {
                return NotFound();
            }
            return View(goalSetting);
        }

        // POST: Goal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,DueDate,IsComplete,AssignedTo,AssignedBy")] GoalSetting goalSetting)
        {
            if (id != goalSetting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goalSetting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoalSettingExists(goalSetting.Id))
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
            return View(goalSetting);
        }

        // GET: Goal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GoalSetting == null)
            {
                return NotFound();
            }

            var goalSetting = await _context.GoalSetting
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goalSetting == null)
            {
                return NotFound();
            }

            return View(goalSetting);
        }

        // POST: Goal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GoalSetting == null)
            {
                return Problem("Entity set 'TimeMateContext.GoalSetting'  is null.");
            }
            var goalSetting = await _context.GoalSetting.FindAsync(id);
            if (goalSetting != null)
            {
                _context.GoalSetting.Remove(goalSetting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoalSettingExists(int id)
        {
          return (_context.GoalSetting?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

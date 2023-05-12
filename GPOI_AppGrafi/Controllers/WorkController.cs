using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GPOI_AppGrafi.Data;
using GPOI_AppGrafi.Models;

namespace GPOI_AppGrafi.Controllers
{
    public class WorkController : Controller
    {
        private readonly GPOI_AppGrafiContext _context;

        public WorkController(GPOI_AppGrafiContext context)
        {
            _context = context;
        }

        // GET: Work
        public async Task<IActionResult> Index()
        {
              return _context.Work != null ? 
                          View(await _context.Work.ToListAsync()) :
                          Problem("Entity set 'GPOI_AppGrafiContext.Work'  is null.");
        }

        // GET: Work/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Work == null)
            {
                return NotFound();
            }

            var work = await _context.Work
                .FirstOrDefaultAsync(m => m.Id == id);
            if (work == null)
            {
                return NotFound();
            }

            return View(work);
        }

        // GET: Work/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Work/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descr")] Work work)
        {
            if (ModelState.IsValid)
            {
                _context.Add(work);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(work);
        }

        // GET: Work/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Work == null)
            {
                return NotFound();
            }

            var work = await _context.Work.FindAsync(id);
            if (work == null)
            {
                return NotFound();
            }
            return View(work);
        }

        // POST: Work/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descr")] Work work)
        {
            if (id != work.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(work);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkExists(work.Id))
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
            return View(work);
        }

        // GET: Work/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Work == null)
            {
                return NotFound();
            }

            var work = await _context.Work
                .FirstOrDefaultAsync(m => m.Id == id);
            if (work == null)
            {
                return NotFound();
            }

            return View(work);
        }

        // POST: Work/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Work == null)
            {
                return Problem("Entity set 'GPOI_AppGrafiContext.Work'  is null.");
            }
            var work = await _context.Work.FindAsync(id);
            if (work != null)
            {
                _context.Work.Remove(work);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkExists(int id)
        {
          return (_context.Work?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

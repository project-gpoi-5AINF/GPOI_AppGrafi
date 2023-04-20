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
    public class EdgesController : Controller
    {
        private readonly GPOI_AppGrafiContext _context;

        public EdgesController(GPOI_AppGrafiContext context)
        {
            _context = context;
        }

        // GET: Edges
        public async Task<IActionResult> Index()
        {
              return _context.Edge != null ? 
                          View(await _context.Edge.ToListAsync()) :
                          Problem("Entity set 'GPOI_AppGrafiContext.Edge'  is null.");
        }

        // GET: Edges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Edge == null)
            {
                return NotFound();
            }

            var edge = await _context.Edge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (edge == null)
            {
                return NotFound();
            }

            return View(edge);
        }

        // GET: Edges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Edges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descr")] Edge edge)
        {
            if (ModelState.IsValid)
            {
                _context.Add(edge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(edge);
        }

        // GET: Edges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Edge == null)
            {
                return NotFound();
            }

            var edge = await _context.Edge.FindAsync(id);
            if (edge == null)
            {
                return NotFound();
            }
            return View(edge);
        }

        // POST: Edges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descr")] Edge edge)
        {
            if (id != edge.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(edge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EdgeExists(edge.Id))
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
            return View(edge);
        }

        // GET: Edges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Edge == null)
            {
                return NotFound();
            }

            var edge = await _context.Edge
                .FirstOrDefaultAsync(m => m.Id == id);
            if (edge == null)
            {
                return NotFound();
            }

            return View(edge);
        }

        // POST: Edges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Edge == null)
            {
                return Problem("Entity set 'GPOI_AppGrafiContext.Edge'  is null.");
            }
            var edge = await _context.Edge.FindAsync(id);
            if (edge != null)
            {
                _context.Edge.Remove(edge);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EdgeExists(int id)
        {
          return (_context.Edge?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

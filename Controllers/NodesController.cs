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
    public class NodesController : Controller
    {
        private readonly GPOI_AppGrafiContext _context;

        public NodesController(GPOI_AppGrafiContext context)
        {
            _context = context;
        }

        // GET: Nodes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Node.ToListAsync());
        }

        // GET: Nodes/Details/5
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null || _context.Node == null)
            {
                return NotFound();
            }

            var node = await _context.Node
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (node == null)
            {
                return NotFound();
            }

            return View(node);
        }

        // GET: Nodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nodes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Node node)
        {
            if (ModelState.IsValid)
            {
                _context.Add(node);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(node);
        }

        // GET: Nodes/Edit/5
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null || _context.Node == null)
            {
                return NotFound();
            }

            var node = await _context.Node.FindAsync(Id);
            if (node == null)
            {
                return NotFound();
            }
            return View(node);
        }

        // POST: Nodes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,Name")] Node node)
        {
            if (Id != node.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(node);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NodeExists(node.Id))
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
            return View(node);
        }

        // GET: Nodes/Delete/5
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null || _context.Node == null)
            {
                return NotFound();
            }

            var node = await _context.Node
                .FirstOrDefaultAsync(m => m.Id == Id);
            if (node == null)
            {
                return NotFound();
            }

            return View(node);
        }

        // POST: Nodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            if (_context.Node == null)
            {
                return Problem("Entity set 'GPOI_AppGrafiContext.Node'  is null.");
            }
            var node = await _context.Node.FindAsync(Id);
            if (node != null)
            {
                _context.Node.Remove(node);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NodeExists(int Id)
        {
          return _context.Node.Any(e => e.Id == Id);
        }
    }
}

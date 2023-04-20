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
    public class NodeSQLsController : Controller
    {
        private readonly GPOI_AppGrafiContext _context;

        public NodeSQLsController(GPOI_AppGrafiContext context)
        {
            _context = context;
        }

        // GET: NodeSQLs
        public async Task<IActionResult> Index()
        {
              return _context.NodeSQL != null ? 
                          View(await _context.NodeSQL.ToListAsync()) :
                          Problem("Entity set 'GPOI_AppGrafiContext.NodeSQL'  is null.");
        }

        // GET: NodeSQLs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NodeSQL == null)
            {
                return NotFound();
            }

            var nodeSQL = await _context.NodeSQL
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nodeSQL == null)
            {
                return NotFound();
            }

            return View(nodeSQL);
        }

        // GET: NodeSQLs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NodeSQLs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Descr,Tipo")] NodeSQL nodeSQL)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nodeSQL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nodeSQL);
        }

        // GET: NodeSQLs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NodeSQL == null)
            {
                return NotFound();
            }

            var nodeSQL = await _context.NodeSQL.FindAsync(id);
            if (nodeSQL == null)
            {
                return NotFound();
            }
            return View(nodeSQL);
        }

        // POST: NodeSQLs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Descr,Tipo")] NodeSQL nodeSQL)
        {
            if (id != nodeSQL.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nodeSQL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NodeSQLExists(nodeSQL.Id))
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
            return View(nodeSQL);
        }

        // GET: NodeSQLs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NodeSQL == null)
            {
                return NotFound();
            }

            var nodeSQL = await _context.NodeSQL
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nodeSQL == null)
            {
                return NotFound();
            }

            return View(nodeSQL);
        }

        // POST: NodeSQLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NodeSQL == null)
            {
                return Problem("Entity set 'GPOI_AppGrafiContext.NodeSQL'  is null.");
            }
            var nodeSQL = await _context.NodeSQL.FindAsync(id);
            if (nodeSQL != null)
            {
                _context.NodeSQL.Remove(nodeSQL);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NodeSQLExists(int id)
        {
          return (_context.NodeSQL?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using diplomMed.Models;

namespace diplomMed.Controllers
{
    public class StretchersController : Controller
    {
        private readonly diplomMedContext _context;

        public StretchersController(diplomMedContext context)
        {
            _context = context;
        }

        // GET: Stretchers
        public async Task<IActionResult> Index()
        {
            var diplomMedContext = _context.Stretchers.Include(s => s.Equip);
            return View(await diplomMedContext.ToListAsync());
        }

        // GET: Stretchers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stretcher = await _context.Stretchers
                .Include(s => s.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stretcher == null)
            {
                return NotFound();
            }

            return View(stretcher);
        }

        // GET: Stretchers/Create
        public IActionResult Create()
        {
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id");
            return View();
        }

        // POST: Stretchers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WorkingCondition,FoldedCondition,EquipId")] Stretcher stretcher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stretcher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", stretcher.EquipId);
            return View(stretcher);
        }

        // GET: Stretchers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stretcher = await _context.Stretchers.FindAsync(id);
            if (stretcher == null)
            {
                return NotFound();
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", stretcher.EquipId);
            return View(stretcher);
        }

        // POST: Stretchers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WorkingCondition,FoldedCondition,EquipId")] Stretcher stretcher)
        {
            if (id != stretcher.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stretcher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StretcherExists(stretcher.Id))
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
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", stretcher.EquipId);
            return View(stretcher);
        }

        // GET: Stretchers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stretcher = await _context.Stretchers
                .Include(s => s.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stretcher == null)
            {
                return NotFound();
            }

            return View(stretcher);
        }

        // POST: Stretchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stretcher = await _context.Stretchers.FindAsync(id);
            _context.Stretchers.Remove(stretcher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StretcherExists(int id)
        {
            return _context.Stretchers.Any(e => e.Id == id);
        }
    }
}

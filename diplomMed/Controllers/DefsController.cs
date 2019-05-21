using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace diplomMed.Models
{
    public class DefsController : Controller
    {
        private readonly diplomMedContext _context;

        public DefsController(diplomMedContext context)
        {
            _context = context;
        }

        // GET: Defs
        public async Task<IActionResult> Index()
        {
            var diplomMedContext = _context.Defs.Include(d => d.Equip);
            return View(await diplomMedContext.ToListAsync());
        }

        // GET: Defs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defs = await _context.Defs
                .Include(d => d.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (defs == null)
            {
                return NotFound();
            }

            return View(defs);
        }

        // GET: Defs/Create
        public IActionResult Create()
        {
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id");
            return View();
        }

        // POST: Defs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Manual,Auto,Synchr,Voice,Ekg,Printer,PulsOxx,Press,Size,EquipId")] Defs defs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(defs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", defs.EquipId);
            return View(defs);
        }

        // GET: Defs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defs = await _context.Defs.FindAsync(id);
            if (defs == null)
            {
                return NotFound();
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", defs.EquipId);
            return View(defs);
        }

        // POST: Defs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Manual,Auto,Synchr,Voice,Ekg,Printer,PulsOxx,Press,Size,EquipId")] Defs defs)
        {
            if (id != defs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(defs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DefsExists(defs.Id))
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
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", defs.EquipId);
            return View(defs);
        }

        // GET: Defs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defs = await _context.Defs
                .Include(d => d.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (defs == null)
            {
                return NotFound();
            }

            return View(defs);
        }

        // POST: Defs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var defs = await _context.Defs.FindAsync(id);
            _context.Defs.Remove(defs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DefsExists(int id)
        {
            return _context.Defs.Any(e => e.Id == id);
        }
    }
}

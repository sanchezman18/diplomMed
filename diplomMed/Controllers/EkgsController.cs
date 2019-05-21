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
    public class EkgsController : Controller
    {
        private readonly diplomMedContext _context;

        public EkgsController(diplomMedContext context)
        {
            _context = context;
        }

        // GET: Ekgs
        public async Task<IActionResult> Index()
        {
            var diplomMedContext = _context.Ekgs.Include(e => e.Equip);
            return View(await diplomMedContext.ToListAsync());
        }

        // GET: Ekgs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ekg = await _context.Ekgs
                .Include(e => e.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ekg == null)
            {
                return NotFound();
            }

            return View(ekg);
        }

        // GET: Ekgs/Create
        public IActionResult Create()
        {
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id");
            return View();
        }

        // POST: Ekgs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConnectPc,SignalProccesing,MemorySize,Size,EquipId")] Ekg ekg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ekg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", ekg.EquipId);
            return View(ekg);
        }

        // GET: Ekgs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ekg = await _context.Ekgs.FindAsync(id);
            if (ekg == null)
            {
                return NotFound();
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", ekg.EquipId);
            return View(ekg);
        }

        // POST: Ekgs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConnectPc,SignalProccesing,MemorySize,Size,EquipId")] Ekg ekg)
        {
            if (id != ekg.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ekg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EkgExists(ekg.Id))
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
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", ekg.EquipId);
            return View(ekg);
        }

        // GET: Ekgs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ekg = await _context.Ekgs
                .Include(e => e.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ekg == null)
            {
                return NotFound();
            }

            return View(ekg);
        }

        // POST: Ekgs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ekg = await _context.Ekgs.FindAsync(id);
            _context.Ekgs.Remove(ekg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EkgExists(int id)
        {
            return _context.Ekgs.Any(e => e.Id == id);
        }
    }
}

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
    public class IvlsController : Controller
    {
        private readonly diplomMedContext _context;

        public IvlsController(diplomMedContext context)
        {
            _context = context;
        }

        // GET: Ivls
        public async Task<IActionResult> Index()
        {
            var diplomMedContext = _context.Ivls.Include(i => i.Equip);
            return View(await diplomMedContext.ToListAsync());
        }

        // GET: Ivls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ivl = await _context.Ivls
                .Include(i => i.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ivl == null)
            {
                return NotFound();
            }

            return View(ivl);
        }

        // GET: Ivls/Create
        public IActionResult Create()
        {
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id");
            return View();
        }

        // POST: Ivls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Time,BatteryType,TimeCharging,WorkModes,EquipId")] Ivl ivl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ivl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", ivl.EquipId);
            return View(ivl);
        }

        // GET: Ivls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ivl = await _context.Ivls.FindAsync(id);
            if (ivl == null)
            {
                return NotFound();
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", ivl.EquipId);
            return View(ivl);
        }

        // POST: Ivls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Time,BatteryType,TimeCharging,WorkModes,EquipId")] Ivl ivl)
        {
            if (id != ivl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ivl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IvlExists(ivl.Id))
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
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", ivl.EquipId);
            return View(ivl);
        }

        // GET: Ivls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ivl = await _context.Ivls
                .Include(i => i.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ivl == null)
            {
                return NotFound();
            }

            return View(ivl);
        }

        // POST: Ivls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ivl = await _context.Ivls.FindAsync(id);
            _context.Ivls.Remove(ivl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IvlExists(int id)
        {
            return _context.Ivls.Any(e => e.Id == id);
        }
    }
}

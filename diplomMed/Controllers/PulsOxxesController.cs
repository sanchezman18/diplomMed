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
    public class PulsOxxesController : Controller
    {
        private readonly diplomMedContext _context;

        public PulsOxxesController(diplomMedContext context)
        {
            _context = context;
        }

        // GET: PulsOxxes
        public async Task<IActionResult> Index()
        {
            var diplomMedContext = _context.PulsOxx.Include(p => p.Equip);
            return View(await diplomMedContext.ToListAsync());
        }

        // GET: PulsOxxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pulsOxx = await _context.PulsOxx
                .Include(p => p.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pulsOxx == null)
            {
                return NotFound();
            }

            return View(pulsOxx);
        }

        // GET: PulsOxxes/Create
        public IActionResult Create()
        {
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id");
            return View();
        }

        // POST: PulsOxxes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Memory,Display,Batteries,Battery,EquipId")] PulsOxx pulsOxx)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pulsOxx);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", pulsOxx.EquipId);
            return View(pulsOxx);
        }

        // GET: PulsOxxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pulsOxx = await _context.PulsOxx.FindAsync(id);
            if (pulsOxx == null)
            {
                return NotFound();
            }
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", pulsOxx.EquipId);
            return View(pulsOxx);
        }

        // POST: PulsOxxes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Memory,Display,Batteries,Battery,EquipId")] PulsOxx pulsOxx)
        {
            if (id != pulsOxx.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pulsOxx);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PulsOxxExists(pulsOxx.Id))
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
            ViewData["EquipId"] = new SelectList(_context.Equips, "Id", "Id", pulsOxx.EquipId);
            return View(pulsOxx);
        }

        // GET: PulsOxxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pulsOxx = await _context.PulsOxx
                .Include(p => p.Equip)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pulsOxx == null)
            {
                return NotFound();
            }

            return View(pulsOxx);
        }

        // POST: PulsOxxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pulsOxx = await _context.PulsOxx.FindAsync(id);
            _context.PulsOxx.Remove(pulsOxx);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PulsOxxExists(int id)
        {
            return _context.PulsOxx.Any(e => e.Id == id);
        }
    }
}

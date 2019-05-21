using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using diplomMed.Models;
using System.IO;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace diplomMed.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly diplomMedContext _context;
        // private readonly List<Equipment> CartList = new List<Equipment>();

        public EquipmentController(diplomMedContext context)
        {
            _context = context;
          
        }



        // GET: Defs
        [Authorize]
        public async Task<IActionResult> Index(string searchString, string defCountry, string numOne, string numTwo, string defCateg, string EquipType)
        {

            IQueryable<string> countQuery = from c in _context.Equips
                                            orderby c.Country
                                            select c.Country;

            var defibs = from d in _context.Equips
                         select d;
            IQueryable<string> typeQuery = from t in _context.Equips
                                           orderby t.EquipType
                                           select t.EquipType;
            string[] categ = { "A", "B", "C" };

             if(defCateg==categ[0])
            {
                defibs = defibs.Where(z => z.Categ1== true);
             }
             if(defCateg == categ[1])
              {
                 defibs = defibs.Where(z => z.Categ2 == true);
              }
            if(defCateg == categ[2])
             {
                 defibs = defibs.Where(z => z.Categ3 == true);
             }
             
           

              if (!string.IsNullOrEmpty(searchString))
              {
                defibs = defibs.Where(s => s.Developer.Contains(searchString));
            }
             if (!string.IsNullOrEmpty(defCountry))
              {
                 defibs = defibs.Where(x => x.Country == defCountry);
             }

             if (!string.IsNullOrEmpty(numOne)&&!string.IsNullOrEmpty(numTwo))
             {
                decimal dNumOne = decimal.Parse(numOne);
               decimal dNumTwo = decimal.Parse(numTwo);
              defibs = defibs.Where(y => y.Price >= dNumOne && y.Price <= dNumTwo);

             }

            if (!string.IsNullOrEmpty(numOne))
            {
                decimal dNumOne = decimal.Parse(numOne);
                defibs = defibs.Where(y => y.Price >= dNumOne);
            }

            if(!string.IsNullOrEmpty(numTwo))
            {
                decimal dNumTwo = decimal.Parse(numTwo);
                defibs = defibs.Where(y => y.Price <= dNumTwo);
            }


            if (!string.IsNullOrEmpty(EquipType))
            {
                defibs = defibs.Where(z => z.EquipType == EquipType);

            }

            var defVM = new EquipmentViewModel
            {
                Countries = new SelectList(await countQuery.Distinct().ToListAsync()),
                Categs = new SelectList(categ),
                EquipTypes = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Equips = await defibs.ToListAsync()
               
        };
            
               return View(defVM);
          
        }

        


        // GET: Defs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Defs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Photo,Developer,Model,Country,Manual,Auto,Synchr,Voice,Ekg,Printer,PulsOxx,Press,Size,Price,Categ1,Categ2,Categ3,EquipType")] EquipHelpModel defH)
        {
            if (ModelState.IsValid)
            {
                Equipment def = new Equipment();
                def.Getter(defH);
                byte[] imageData = null;
           
               using (var binaryReader = new BinaryReader(defH.Photo.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)defH.Photo.Length);
                }
                def.Photo = imageData;

                _context.Add(def);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(defH);
        }
        // GET DefsCreate
        public IActionResult DefsCreate()
        {
            SelectList equips = new SelectList(_context.Equips, "Id", "Model");
            ViewBag.EquipId = equips;
            return View();
        }
        // Post DefsCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DefsCreate([Bind("Id,Manual,Auto,Synchr,Voice,Ekg,Printer,PulsOxx,Press,Size,EquipId")]Defs defs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(defs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(defs);
        }
        public IActionResult EkgCreate()
        {
            SelectList equips = new SelectList(_context.Equips, "Id", "Model");
            ViewBag.EquipId = equips;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EkgCreate([Bind("Id,ConnectPc,SignalProccesing,MemorySize,Size,EquipId")]Ekg ekgs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ekgs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ekgs);
        }
        public IActionResult IvlCreate()
        {
            SelectList equips = new SelectList(_context.Equips, "Id", "Model");
            ViewBag.EquipId = equips;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IvlCreate([Bind("Id,Time, BatteryType,TimeCharging,WorkModes,EquipId")] Ivl ivls)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ivls);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(ivls);
        }
        public IActionResult MonitorCreate()
        {
            SelectList equips = new SelectList(_context.Equips, "Id", "Model");
            ViewBag.EquipId = equips;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MonitorCreate([Bind("Id,Ekg,Ad,Kapn,Pulsoxxx,Diagonal,Resol,EquipId")] Monitor monitor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monitor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monitor);
        }
        public IActionResult PulsOxxCreate()
        {
            SelectList equips = new SelectList(_context.Equips, "Id", "Model");
            ViewBag.EquipId = equips;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PulsOxxCreate([Bind("Id,Memory,Display,Batteries,Battery,EquipId")] PulsOxx puls)
        {
            if (ModelState.IsValid)
            {
                _context.Add(puls);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(puls);
        }

        public IActionResult StretcherCreate()
        {
            SelectList equips = new SelectList(_context.Equips, "Id", "Model");
            ViewBag.EquipId = equips;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StretcherCreate([Bind("Id,WorkingCondition,FoldedCondition")] Stretcher str)
        {
            if (ModelState.IsValid)
            {
                _context.Add(str);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(str);
        }
       


        // GET: Defs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //  var defs = await _context.Equips.FindAsync(id);
            
            var defs = await _context.Equips.
                FirstOrDefaultAsync(f => f.Id == id);
          

            if (defs == null)
            {
                return NotFound();
            }
            return View(defs);
        }

        // POST: Defs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id,IFormFile file)
        {
            if (id == null)
            {
                return NotFound();
            }

                var equipsToUpate = await _context.Equips.FirstOrDefaultAsync(s => s.Id == id);
                if (await TryUpdateModelAsync<Equipment>(
                    equipsToUpate, "", s => s.EquipType, s => s.Developer, s => s.Model, s => s.Country, s => s.Price, s => s.Categ1, s => s.Categ2, s => s.Categ3


                    ))
                {
                    try
                    {
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }

                    catch (DbUpdateException)
                    {
                        ModelState.AddModelError("", "Unable to save changes");
                    }
                }
          
            else if(file != null) {
                
            }
            return View(equipsToUpate);
        }
        

        // public async Task<IActionResult> Edit(int id,[Bind("Id,Photo,Developer,Model,Country,Manual,Auto,Synchr,Voice,Ekg,Printer,PulsOxx,Press,Size,Price")] Equipment defs)
      //  public async Task<IActionResult> Edit(int id, string Dev, string Model, string Country, decimal Price, string Manual )

      /* public async Task<IActionResult> Edit(int id, [Bind("Id,EquipType,Photo,Developer,Model,Country,Press,Size,Price,Categ1,Categ2,Categ3")]Equipment defs)
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
            return View(defs);
        }*/

     

        // GET: Defs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var defs = await _context.Equips
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
            var defs = await _context.Equips.FindAsync(id);
            _context.Equips.Remove(defs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var def = await _context.Equips.Include(m=>m.Defs).Include(m=>m.Ekgs)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (def == null)
            {
                return NotFound();
            }

            return View(def);
        }

        private bool DefsExists(int id)
        {
            return _context.Equips.Any(e => e.Id == id);
        }
    }
}

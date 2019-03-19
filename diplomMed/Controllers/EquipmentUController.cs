using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using diplomMed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace diplomMed.Controllers
{
    public class EquipmentUController : Controller
    {
        private readonly diplomMedContext _context;
        private List<Equipment> CartList = new List<Equipment>();
        public EquipmentUController(diplomMedContext context)
        {
            _context = context;
        }

        

        public async Task<IActionResult> Index(string EquipType, string defCateg, string numOne, string numTwo, string defCountry)
        {
            IQueryable<string> countQuery = from c in _context.Equips
                                            orderby c.Country
                                            select c.Country;
            IQueryable<string> typeQuery = from t in _context.Equips
                                           orderby t.EquipType
                                           select t.EquipType;



            var equipments = from e in _context.Equips
                             select e;
            string[] categ = { "A", "B", "C" };
            if (defCateg == categ[0])
            {
                equipments = equipments.Where(x => x.Categ1 == true);
            }
            if (defCateg == categ[1])
            {
                equipments = equipments.Where(x => x.Categ2 == true);
            }
            if(defCateg == categ[2])
            {
                equipments = equipments.Where(x => x.Categ3 == true);
            }

            if (!string.IsNullOrEmpty(defCountry))
            {
                equipments = equipments.Where(x => x.Country == defCountry);
            }

            if (!string.IsNullOrEmpty(numOne) && !string.IsNullOrEmpty(numTwo))
            {
                decimal dNumOne = decimal.Parse(numOne);
                decimal dNumTwo = decimal.Parse(numTwo);
                equipments = equipments.Where(y => y.Price >= dNumOne && y.Price <= dNumTwo);

            }
            if (!string.IsNullOrEmpty(EquipType))
            {
                equipments = equipments.Where(z=>z.EquipType == EquipType);

            }

            var EquipH = new EquipmentViewModel
            {
                Countries = new SelectList(await countQuery.Distinct().ToListAsync()),
                Categs = new SelectList(categ),
                EquipTypes = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Equips = await equipments.ToListAsync()

            };
            return View(EquipH);

        }
        public async Task<IActionResult> Details(int? id, string retutnURL)
        {
            if (id == null)
            {
                return NotFound();
            }

            var def = await _context.Equips.Include(m => m.Defs).Include(m => m.Ekgs).Include(m => m.Ivls).Include(m => m.Monitors).Include(m => m.PulsOxxs).Include(m => m.Stretchers)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (def == null)
            {
                return NotFound();
            }

            var dvm = new DetailViewModel
            {
                Equip = def,
                retutnUrl = retutnURL
        };
            

            return View(dvm);
        }
     //   public async RedirectToActionResult Haract(int? id, string returnURL)
     //   {
    //         var def = await _context.Equips.Include(m => m.Defs).Include(m => m.Ekgs).Include(m => m.Ivls).Include(m => m.Monitors).Include(m => m.PulsOxxs).Include(m => m.Stretchers)
   //              .FirstOrDefaultAsync(m => m.Id == id);
   //     }

   //     public ViewResult Details(string returnURL)
   //     {
    //        return View(new DetailViewModel
     //       {

     //       }
           //     );
        //}

    }
}
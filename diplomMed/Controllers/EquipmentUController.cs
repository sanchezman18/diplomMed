using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using diplomMed.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
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
        private void Country(string EquipType, IQueryable<string> countQuery)
        {


        }



        public async Task<IActionResult> Index(string EquipType, string defCateg, string numOne, string numTwo, string defCountry)
        {
            IQueryable<string> countQuery = from c in _context.Equips
                                            orderby c.Country
                                            select c.Country;

            IQueryable<string> typeQuery = from t in _context.Equips
                                           orderby t.EquipType
                                           select t.EquipType;



            var equipments = from e in _context.Equips.Include(d => d.Defs)
                             select e;
            //var countries = from c in _context.Equips
              //              orderby c.Country


            string[] categ = { "A", "B", "C" };
            if (defCateg == categ[0])
            {
                equipments = equipments.Where(x => x.Categ1 == true);
            }
            if (defCateg == categ[1])
            {
                equipments = equipments.Where(x => x.Categ2 == true);
            }
            if (defCateg == categ[2])
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

            if (!string.IsNullOrEmpty(numOne))
            {
                decimal dNumOne = decimal.Parse(numOne);
                equipments = equipments.Where(y => y.Price >= dNumOne);
            }

            if (!string.IsNullOrEmpty(numTwo))
            {
                decimal dNumTwo = decimal.Parse(numTwo);
                equipments = equipments.Where(y => y.Price <= dNumTwo);
            }

            if (!string.IsNullOrEmpty(EquipType))
            {
                equipments = equipments.Where(z => z.EquipType == EquipType);

            }

            var EquipH = new EquipmentViewModel
            {
                Countries = new SelectList(await countQuery.Distinct().ToListAsync()),
                //  Countries = new SelectList( ),

                Categs = new SelectList(categ),
                EquipTypes = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Equips = await equipments.ToListAsync()
            //   Equips = null

            };

            return View(EquipH);

        }


        public async Task<IActionResult> Details(int? id, string returnURL)
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

            if (returnURL == null)
            {
                return NotFound();
            }

            return View(new DetailViewModel
            {
                Equip = def,
                returnURL = returnURL
            }
            );



        }

        /////
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {
              //  User user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (model.Email.Trim()=="sasha" && model.Password=="123456")
                {
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Equipment");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
    
        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));

        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

    }
}

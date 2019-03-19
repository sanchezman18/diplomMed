using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using diplomMed.Infrastructure;
using diplomMed.Models;
using Microsoft.AspNetCore.Mvc;

namespace diplomMed.Controllers
{
    public class CartController : Controller
    {
        private readonly diplomMedContext _context;
        private Cart cart;

        public CartController(diplomMedContext context, Cart cartService)
        {
            _context = context;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int Id, string returnURL)

        {


            Equipment equipment = _context.Equips.FirstOrDefault(p => p.Id == Id);


            if (equipment != null)
            {
                // Cart cart = GetCart();
                cart.AddItem(equipment, 1);
                //SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnURL });
        }

        public RedirectToActionResult RemoveFromCart(int Id, string returnUrl)
        {
            Equipment equipment = _context.Equips.FirstOrDefault(p => p.Id == Id);

            if (equipment != null)
            {
                //Cart cart = GetCart();
                cart.RemoveLine(equipment);
                //SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        //  private Cart GetCart()
        //{
        //    Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        //   return cart;
        //   }

        //  private void SaveCart(Cart cart)
        // {
        //     HttpContext.Session.SetJson("Cart", cart);
        //  }

        //}
    }
}
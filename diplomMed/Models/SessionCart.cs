using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using diplomMed.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace diplomMed.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;

       }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Equipment equipment, int quantity)
        {
            base.AddItem(equipment, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Equipment equipment)
        {
            base.RemoveLine(equipment);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }

    }
}

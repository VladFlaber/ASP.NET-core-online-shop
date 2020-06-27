using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Shop.Infrastructure;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Session;
using Shop.Infrastructure.Extensions;

namespace Shop.Models
{
    public class SessionCart:Cart
    {
        public static Cart GetCart(IServiceProvider service) 
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.getJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
        [JsonIgnore]
        private ISession Session { get; set; }
        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session.setJson("Cart", this);

        }
        public override void RemoveItem(Product product)
        {
            base.RemoveItem(product);
            Session.setJson("Cart", this);

        }
        public override void Clear( )
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}

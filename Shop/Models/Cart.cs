using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Cart
    {
        private List<CartItem> cartItems = new List<CartItem>();
        public IEnumerable<CartItem> CartItems => cartItems;
        public virtual void AddItem(Product good, int quantity)
        {
            CartItem cartItem = cartItems.FirstOrDefault(g => g.Product.Id == good.Id);
            if (cartItem != null)
                cartItem.Quantity += quantity;
            else
                cartItems.Add(new CartItem { Product = good, Quantity = quantity });
        }
        public virtual void RemoveItem(Product good)
        {
            cartItems.RemoveAll(c => c.Product.Id == good.Id);
        }
        public decimal CalculateTotalValue()
        {
            return cartItems.Sum(c => c.Product.Price * c.Quantity);
        }
        public virtual void Clear()
        {
            cartItems.Clear();
        }

    }
}
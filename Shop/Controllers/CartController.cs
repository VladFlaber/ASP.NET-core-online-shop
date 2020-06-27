using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repositories.Interfaces;
using Shop.Infrastructure;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository products;
        private Cart cart;
        public CartController(IProductRepository repo,Cart cartService )
        {
            this.products = repo;
            this.cart = cartService;
        }
        public IActionResult Index(string returnUrl) =>
            View(new CartIndexViewModel() { Cart = cart, ReturnUrl = returnUrl });
       
        public RedirectToActionResult AddToCart(int Id, string returnUrl)
        {
            Product product = products.GetById(Id);
            if (product!=null)
            {
                cart.AddItem(product, 1);              
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int Id, string returnUrl)
        {
            Product product = products.GetById(Id);
            if (product!=null)
            {          
                cart.RemoveItem(product);           
            }
            return RedirectToAction("Index", new { returnUrl });
        }
      
    }
}
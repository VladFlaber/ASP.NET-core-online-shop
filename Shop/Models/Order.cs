using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        [BindNever]
        public ICollection<CartItem> cartItems { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the first adress line")]
        public string AdressLine { get; set; }
        [Required(ErrorMessage = "Please enter the first adress line")]
        public string City { get; set; }
        public string Country { get; set; }
        public bool GiftWrap { get; set; }

    }

}

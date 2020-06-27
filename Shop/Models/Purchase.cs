using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Purchase : IEntity
    {
        public Purchase()
        {
            Products = new List<Product>();
            DatePurchase = DateTime.Now;
        }
        [HiddenInput]

        public int Id { get; set; }

        // [DataType(DataType.Date)]
        [Display(Name = "Дата и время покупки")]
        public DateTime DatePurchase { get; set; }
        [Display(Name = "Сумма покупки")]
        public decimal TotalPayed { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection <Product>Products { get; set; }
    }
}
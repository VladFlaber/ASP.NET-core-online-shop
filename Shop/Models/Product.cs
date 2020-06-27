using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Product : IEntity
    {
        public Product()
        {
            ProductImages = new List<ProductImage>();
            UserComments = new List<UserComment>();
         //   ProductStorages = new List<ProductStorage>();
         //   Purchases = new List<Purchase>();
        }
        [HiddenInput]
        public int Id { get; set; }

        /// <summary>
        /// Presents name of the product in the store
        /// </summary>
        [Display(Name = "Модель")]
        public string Name { get; set; }
        /// <summary>
        /// Presents 
        /// </summary>
        [Display(Name = "Цена")]        
        public decimal Price { get; set; }
        [Display(Name = "Вес")]
        public double Weight { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Range(0, int.MaxValue)]
        public int Rating { get; set; }    
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<UserComment> UserComments { get; set; }
        //public virtual ICollection<ProductStorage> ProductStorages { get; set; }
      //  public virtual ICollection<Purchase> Purchases { get; set; }
        public int? SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public int? ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class ProductStorage : IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Adress of storage where products are located
        /// </summary>
        [Required]
        public string Adress { get; set; }
        /// <summary>
        /// Phone number of storage 
        /// </summary>
        [Phone]
        [Required]
        public string Phone { get; set; }
        /// <summary>
        /// Quantity of the one of product type stored
        /// </summary>
        public int ProductsQuantity { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
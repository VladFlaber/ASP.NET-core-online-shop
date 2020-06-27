using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class SubCategory : IEntity
    {
        public SubCategory()
        {
            Products = new List<Product>();
        }
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
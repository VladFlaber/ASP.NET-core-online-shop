using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Category:IEntity
    {
        public int Id { get; set; }

        public Category()
        {
            SubCategories = new List<SubCategory>();
        }       
        /// <summary>
        /// Name of category to which Subcategories belongs to
        /// </summary>
        [Display(Name="Категория")]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Subcategories with foreign key to this Category
        /// </summary>
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
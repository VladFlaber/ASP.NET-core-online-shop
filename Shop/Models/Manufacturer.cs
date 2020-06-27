using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Manufacturer:IEntity
    {
        public Manufacturer()
        {
            ManufacturerContacts = new List<ManufacturerContact>();
            Products = new List<Product>();
        }
        public int Id { get; set; }

        /// <summary>
        /// Presents manufacturer's company name
        /// </summary>
        [Display(Name="Имя компании-производителя")]
        [Required]
        public string CompanyName { get; set; }
        /// <summary>
        /// Presents list of contacts to contacts with manufacturer
        /// </summary>
        public virtual ICollection<ManufacturerContact> ManufacturerContacts { get; set; }
        /// <summary>
        /// Presents list of products this manufacturer produce
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
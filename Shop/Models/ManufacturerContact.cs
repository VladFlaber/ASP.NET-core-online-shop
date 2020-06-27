using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class ManufacturerContact : IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Presents legal adress of manufacturer. Required
        /// </summary>
        [DisplayName("Юридический адресс")]
        [Required]
        public string Adress { get; set; }
        /// <summary>
        /// Presents manufacturer's web site. Must be corresponded to regular URL. Not Required
        /// </summary>
        [Display(Name="Веб-сайт")]
        [Url]
        public string Website { get; set; }
        /// <summary>
        /// Presents manufacturer's E-Mail. Must be corresponded to regular E-Mail adress. Not required
        /// </summary>
        [EmailAddress]
        [Display(Name = "E-Mail")]

        public string Email { get; set; }
        /// <summary>
        /// Presents manufacturer's technical support phone number. Not required
        /// </summary>
        [Phone]
        [Display(Name="Служба поддержки")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// A foreign key of the Manufacturer  to which this contact belongs to
        /// </summary>
        [HiddenInput]
        public int ManufacturerId { get; set; }
        /// <summary>
        /// A navigation property  of the Manufacturer  to which this contact belongs to
        /// </summary>
        public virtual Manufacturer Manufacturer { get; set; }

    }
}
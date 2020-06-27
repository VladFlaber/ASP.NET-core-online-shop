using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ProductViewModel
    {
        public string Category { get; set; }
        public Product Product { get; set; }
        public string FrontImage { get; set; }
        public int CommentsCount { get; set; }
        public string ManufacturerName { get; set; }
        public ProductViewModel() { }
        public ProductViewModel(string cat, Product pr, string image, int count,string manufacturer)
        {
            this.Category = cat;
            this.FrontImage = image;
            this.Product = pr;
            this.ManufacturerName = manufacturer;
            this.CommentsCount = count;
        }
    }
}

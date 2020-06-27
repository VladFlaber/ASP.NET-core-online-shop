using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }

        public string Path { get; set; }
       
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
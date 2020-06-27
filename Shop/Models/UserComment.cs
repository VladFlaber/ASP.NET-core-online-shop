﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class UserComment : IEntity
    {
        public UserComment()
        {
            DatePublished = DateTime.Now;
        }
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Text { get; set; }
        public DateTime DatePublished { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class User : IEntity
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [EmailAddress]
        [Required]
        [Display(Name="E-mail")]
        public string Email { get; set; }
        [Phone]
        [Display(Name="Телефон для связи")]
        [Required]
        public string Phone { get; set; }
        [Display(Name = "Логин")]
        [Required]
        public string Login { get; set; }
        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [HiddenInput]
        public bool IsBlocked { get; set; }
        [HiddenInput]
        public string Description { get; set; }
        public virtual ICollection < Purchase > UsersPurchases { get; set; }
        public virtual ICollection<UserComment> UserComments { get; set; }
    }
}
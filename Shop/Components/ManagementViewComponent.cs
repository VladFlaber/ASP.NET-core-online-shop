using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Components
{
    public class ManagementViewComponent:ViewComponent
    {
     public  List <string > ManagementItems { get; set; }
        public ManagementViewComponent()
        {
            ManagementItems = new List<string>()
            {
                "Товары","Категории","Подкатегории",
                "Пользователи",
            };
        }
        public IViewComponentResult Invoke() => View(ManagementItems);

    }
}

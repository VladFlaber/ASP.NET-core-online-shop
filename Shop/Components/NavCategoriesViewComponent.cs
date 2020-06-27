using Microsoft.AspNetCore.Mvc;
using Shop.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Components
{
    public class NavCategoriesViewComponent:ViewComponent
    {
        ICategoryRepository repo;
        public NavCategoriesViewComponent(ICategoryRepository repository)
        {
            this.repo = repository;
        }
        public IViewComponentResult Invoke() =>
            View(repo.GetCategoriesWithSubCategories().Result.OrderBy(c=>c.Name));
       
    }
}

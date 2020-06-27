using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repositories;
using Shop.Repositories.Interfaces;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        //ICategoryRepository categories;
        IUnitOfWork uow;
        public CategoryController(IUnitOfWork unitofwork)
        {
            this.uow = unitofwork;
            //this.categories = repo;
        }
        [Route("/Admin/Category/List")]
        public async Task<IActionResult>List() =>
        View(await uow.Categories.getAll().ConfigureAwait(false));

        
        public IActionResult AddCategory()
        {
            var category = new Category { };
            return PartialView("CategoryView", category);

        }
        [HttpPost]
        [Route("/Admin/Category/AddCategory")]
        public async Task< IActionResult >AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {

                uow.Categories.Add(category);
                await uow.Save();
            }
            //return View("List",categories.getAll().Result);
            return PartialView("CategoryView", category);
        }
    }
}
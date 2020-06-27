using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Models;
using Shop.Repositories;
using Shop.Repositories.Interfaces;
using Shop.ViewModels;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        //IProductRepository products;
        //ISubCategoryRepository subCategories;
        IUnitOfWork uow;
        int PageSize = 20;
        public ProductsController(IUnitOfWork unit/*IProductRepository rep, ISubCategoryRepository repo2*/)
        {
            this.uow = unit;
            //this.products = rep;
            //this.subCategories = repo2;
        }
        [Route("/Admin/Products/List")]
        public IActionResult List(int page=1, string category=null)
        {
            IEnumerable<Product> get = category == null ?
                uow.Products.getWithAllIncludes().Result :
                uow.Products.getWithAllIncludesByCategoryName(category).Result;
            IEnumerable<ProductViewModel> list = get.Select(o => new ProductViewModel(o.SubCategory.Name, o,
                o.ProductImages.Select(i => i.Path).FirstOrDefault()
                , o.UserComments.Count, o.Manufacturer.CompanyName));

            list = list.Skip((page - 1) * PageSize).Take(PageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = PageSize, TotalItems = get.Count() };
            ProductIndexViewModel Pr = new ProductIndexViewModel
            { PageInfo = pageInfo, Products = list, SelectedCategory = category };
            //return View(Pr);
            return View(Pr);
                     
        }
       
        public IActionResult AddProduct()
        {
            var product = new Product { };
            ViewBag.subcategories = new SelectList(uow.SubCategories.getAll().Result,"Id","Name");
            return PartialView("ProductView",product);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.SubCategoryId.HasValue&&product.ManufacturerId.HasValue)
                {
                    try
                    {
                        var subcategory = uow.SubCategories.GetById(product.SubCategoryId.Value);
                        var manufacturer = uow.Manufacturers.GetById(product.ManufacturerId.Value);
                        subcategory.Products.Add(product);
                        manufacturer.Products.Add(product);

                        var images = product.ProductImages;
                        foreach (var img in images)
                        {
                            uow.ProductImages.Add(img);
                        }
                        uow.Products.Add(product);
                        uow.Save();
                    }
                    catch (Exception)
                    {

                        
                    }
                }
            }
            return PartialView("ProductView", product);

        }
    }
}
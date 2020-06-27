using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Models;
using Shop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IProductRepository productRepo;
         
        int PageSize = 12;
        public HomeController(IProductRepository repo, ILogger<HomeController> logger)
        {
            _logger = logger;
            this.productRepo = repo;
        }
        public async  Task<IActionResult> Index(int page = 1, string category = null)
        {
            IEnumerable<Product> products = category == null ?
               await productRepo.getWithAllIncludes().ConfigureAwait(false) :
                await productRepo.getWithAllIncludesByCategoryName(category).ConfigureAwait(false);
            IEnumerable<ProductViewModel> list = products.Select(o => new ProductViewModel(o.SubCategory.Name, o,
                o.ProductImages.Select(i => i.Path).FirstOrDefault()
                , o.UserComments.Count, o.Manufacturer.CompanyName));
            
            list = list.Skip((page - 1) * PageSize).Take(PageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = PageSize, TotalItems = products.Count() };
            ProductIndexViewModel Pr = new ProductIndexViewModel
            { PageInfo = pageInfo, Products = list, SelectedCategory = category };

            return PartialView("ProductSummary", Pr);

        }
        [HttpPost]
        public async Task<IActionResult>Search(int page=1,string searchRequest=null/*,string sortOrder="Rating"*/)
        {
            IEnumerable<Product> products = searchRequest == null ?
             await  productRepo.getWithAllIncludes() :
               productRepo.getWithAllIncludes().Result.Where(
                   p=>p.Name.ToLower().Contains(searchRequest.ToLower()));

            IEnumerable<ProductViewModel> list = products.Select(o => new ProductViewModel(o.SubCategory.Name, o,
                o.ProductImages.Select(i => i.Path).FirstOrDefault()
                , o.UserComments.Count, o.Manufacturer.CompanyName));

            list = list.Skip((page - 1) * PageSize).Take(PageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = PageSize, TotalItems = products.Count() };
            //SortList(list,sortOrder);
            ProductIndexViewModel Pr = new ProductIndexViewModel
            { PageInfo = pageInfo, Products = list, SelectedCategory = "dsf" };
            return PartialView("ProductSummary", Pr);
        }
        private void  SortList(IEnumerable<ProductViewModel> list, string sortOrder)
        {
            switch (sortOrder)
            {
                case "Rating":
                    {
                        list.OrderByDescending(p => p.Product.Rating);
                        break;
                    }
                case "PriceASC":
                    {
                        list.OrderBy(p => p.Product.Price);
                        break;
                    }
                case "PriceDESC":
                    {
                        list.OrderByDescending(p => p.Product.Price);
                        break;
                    }
                case "Comments":
                    {
                        list.OrderByDescending(p => p.CommentsCount);
                        break;
                    }
                default:
                    break;
            }
          
        }
        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult ProductDetails(int? id)
        {
            if (id.HasValue)
            {
                int ProdId = id.GetValueOrDefault();
                var Product = productRepo.GetByIdWithAllIncludes(ProdId);
                string[] description = Product.Description.Split("\n");

                ViewBag.Description = description;
                if (Product != null)
                    return View(Product);
                else
                    return NotFound("Продукт не найден");
            }
            else
            {
                return NotFound(404);
            }
        }
            
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

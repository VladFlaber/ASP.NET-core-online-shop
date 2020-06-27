using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
    public interface IProductRepository
    {
        //Task <List<Product>> getProductsWithSubBcategory(string subCategoryName);
        //Task<List<ProductViewModel>> getViewModelBySubCategory(string subCategoryName);
        //Task<List<ProductViewModel>> getViewModel();
        IEnumerable<Product> getAll();
        void Add(Product entity);
        void Remove(int id);
        bool Edit(Product entity);
        Product GetById(int id);
        Product GetByIdWithAllIncludes(int id);
        Task<IEnumerable<Product>> getWithAllIncludes();
        Task<IEnumerable<Product>> getWithAllIncludesByCategoryName(string subCategoryName);
    }
}

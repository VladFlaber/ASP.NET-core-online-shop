using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
  public  interface ICategoryRepository:IDisposable
    {
        Task< IEnumerable<Category>> getAll();
        void Add(Category entity);
        void Remove(int id);
        bool Edit(Category entity);
        Category GetById(int id);
        Task <IEnumerable<Category>> GetCategoriesWithSubCategories();
    }
}

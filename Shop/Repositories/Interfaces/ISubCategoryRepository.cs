using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
    public interface ISubCategoryRepository :IDisposable
    {
        Task<IEnumerable<SubCategory>> getAll();
        void Add(SubCategory entity);
        void Remove(int id);
        bool Edit(SubCategory entity);
        Task<IEnumerable<SubCategory>>  getAllWithProducts();
        SubCategory GetById(int id);

    }
}

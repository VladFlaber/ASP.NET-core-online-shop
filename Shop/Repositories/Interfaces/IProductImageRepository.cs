using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
    public interface IProductImageRepository
    {
        Task<IEnumerable<ProductImage>> getAll();
        void Add(ProductImage entity);
        void Remove(int id);
        bool Edit(ProductImage entity);
        ProductImage GetById(int id);
    }
}

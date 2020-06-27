using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.EFCustomRepositories
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Models;
    using Shop.ViewModels;

    public class ProductRepository :Shop.Repositories.Interfaces.IProductRepository
    {
        //private readonly StoreContext db;
        readonly StoreContext db;
        public ProductRepository(StoreContext context)
        {
            this.db = context;
        }
        public void Add(Product entity)
        {
            db.Products.Add(entity);
            //db.SaveChanges();

        }
       
        public bool Edit(Product entity)
        {
            Product selected = GetById(entity.Id);
            if (selected != null)
            {
                selected.Name = entity.Name;
                selected.Manufacturer = entity.Manufacturer;
                selected.Price = entity.Price;
                selected.ProductImages = entity.ProductImages;
                selected.Rating = entity.Rating;
                selected.SubCategory = entity.SubCategory;
                selected.Weight = entity.Weight;
                selected.Description = entity.Description;
                db.Entry(selected).State = EntityState.Modified;
                //db.SaveChanges();
                return true;
            }
            return false;

        }

        public IEnumerable<Product> getAll()
        {
            return db.Products;

        }

        public Product GetById(int id)
        {
            return db.Products.Find(id);
        }

        public void Remove(int id)
        {
            Product product = GetById(id);
            if (product != null)
            {
                db.Products.Remove(product);
                //db.SaveChanges();
            }

        }
        public IQueryable getProductsWithSubCategories()
        {
          
            return db.Products.Include("SubCategories").Select(p=> new { p.Name,Sub= p.SubCategory.Name });            
        }
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }

        public async Task<IEnumerable<Product>> getWithAllIncludesByCategoryName(string subCategoryName)
        {
            return await db.Products.Include(p => p.SubCategory)
                .Include(p => p.ProductImages)
                .Include(p => p.Manufacturer).Include(p => p.UserComments)
                .Where(p => p.SubCategory.Name == subCategoryName).ToListAsync();
        }
        public async Task<IEnumerable<Product>> getWithAllIncludes()
        {
            return await db.Products.Include(p => p.SubCategory)
                .Include(p => p.ProductImages)
                .Include(p => p.Manufacturer).Include(p => p.UserComments)
                .ToListAsync();
        }

        public  Product GetByIdWithAllIncludes(int id)
        {
            Product pr = getWithAllIncludes().Result.FirstOrDefault(pr => pr.Id == id);
            return pr;
        }

       
    }
}

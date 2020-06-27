using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.EFCustomRepositories
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Models;
    using Shop.Repositories.Interfaces;

    public class ProductImageRepository : IProductImageRepository
    {
        //private readonly StoreContext db;
        readonly StoreContext db;
        public ProductImageRepository(StoreContext context)
        {
            this.db = context;
        }
        public void Add(ProductImage entity)
        {
            db.ProductImages.Add(entity);
            db.SaveChanges();

        }

        public bool Edit(ProductImage entity)
        {
            ProductImage selected = GetById(entity.Id);
            if (selected != null)
            {
                selected.Path = entity.Path;
                selected.Product = entity.Product;
                db.Entry(selected).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;

        }

        public async  Task<IEnumerable<ProductImage>> getAll()
        {
            return await db.ProductImages.ToListAsync();

        }

        public ProductImage GetById(int id)
        {
            return db.ProductImages.Find(id);
        }

        public void Remove(int id)
        {
            ProductImage ProductImage = GetById(id);
            if (ProductImage != null)
            {
                db.ProductImages.Remove(ProductImage);
                db.SaveChanges();
            }

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Repositories.Interfaces;
namespace Shop.Repositories.EFCustomRepositories
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Models;
    public class SubCategoryRepository : ISubCategoryRepository 
    { 
        //private readonly StoreContext db;
        readonly StoreContext db;
        public SubCategoryRepository(StoreContext context)
        {
            this.db = context;
        }
        public void Add(SubCategory entity)
        {
            db.SubCategories.Add(entity);
            db.SaveChanges();

        }

        public bool Edit(SubCategory entity)
        {
            SubCategory selected = GetById(entity.Id);
            if (selected != null)
            {
                selected.Name = entity.Name;
                selected.Products = entity.Products;
                selected.Category = entity.Category;
               
                db.Entry(selected).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<SubCategory>> getAll()
        {
            return await db.SubCategories.ToListAsync();

        }
        public async Task<IEnumerable<SubCategory>> getAllWithProducts()
        {
            return await db.SubCategories.Include(s => s.Products).ToListAsync();
        }
        public SubCategory GetById(int id)
        {
            return db.SubCategories.Find(id);
        }

        public void Remove(int id)
        {
            SubCategory subcategory = GetById(id);
            if (subcategory != null)
            {
                db.SubCategories.Remove(subcategory);
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
                    // TODO: dispose managed state
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

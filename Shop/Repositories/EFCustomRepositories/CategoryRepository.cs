using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.EFCustomRepositories
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Models;
    public class CategoryRepository : Shop.Repositories.Interfaces.ICategoryRepository
    {
        //private readonly StoreContext db;
        readonly StoreContext db;
        public CategoryRepository(StoreContext context)
        {
            this.db = context;
        }
        public void Add(Category entity)
        {
            db.Categories.Add(entity);
            //db.SaveChanges();

        }

        public bool Edit(Category entity)
        {
            Category selected = GetById(entity.Id);
            if (selected != null)
            {
                selected.Name = entity.Name;
                selected.SubCategories = entity.SubCategories;
                db.Entry(selected).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<Category>> getAll()
        {
            return await db.Categories.ToListAsync();

        }

        public Category GetById(int id)
        {
            return db.Categories.Find(id);
        }

        public void Remove(int id)
        {
            Category category = GetById(id);
            if (category != null)
            {
                db.Categories.Remove(category);
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
        public async Task<IEnumerable<Category>> GetCategoriesWithSubCategories() =>
         await db.Categories.Include(c => c.SubCategories).ToListAsync();
    }
}

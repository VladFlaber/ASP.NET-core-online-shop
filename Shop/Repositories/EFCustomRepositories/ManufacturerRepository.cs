using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.EFCustomRepositories
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Models;
    using Shop.Repositories.Interfaces;

    public class ManufacturerRepository : IManufacturerRepository
    {
        //private readonly StoreContext db;
        readonly StoreContext db;
        public ManufacturerRepository(StoreContext context)
        {
            this.db = context;
        }
        public void Add(Manufacturer entity)
        {
            db.Manufacturers.Add(entity);
            db.SaveChanges();

        }

        public bool Edit(Manufacturer entity)
        {
            Manufacturer selected = GetById(entity.Id);
            if (selected != null)
            {
                selected.CompanyName = entity.CompanyName;
                selected.ManufacturerContacts = entity.ManufacturerContacts;
                selected.Products = entity.Products;               

                db.Entry(selected).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<Manufacturer>> getAll()
        {
            return await db.Manufacturers.ToListAsync();

        }

        public Manufacturer GetById(int id)
        {
            return db.Manufacturers.Find(id);
        }

        public void Remove(int id)
        {
            Manufacturer Manufacturer = GetById(id);
            if (Manufacturer != null)
            {
                db.Manufacturers.Remove(Manufacturer);
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

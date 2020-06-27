//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Shop.Repositories
//{
//    using Microsoft.EntityFrameworkCore;
//    using Shop.Models;
//    public class ManufacturerContactRepository : IRepository<ManufacturerContact>
//    {
//        //private readonly StoreContext db;
//        readonly StoreContext db;
//        public ManufacturerContactRepository(StoreContext context)
//        {
//            this.db = context;
//        }
//        public void Add(ManufacturerContact entity)
//        {
//            db.ManufacturerContacts.Add(entity);
//            db.SaveChanges();

//        }

//        public bool Edit(ManufacturerContact entity)
//        {
//            ManufacturerContact selected = GetById(entity.Id);
//            if (selected != null)
//            {
//                selected.Manufacturer = entity.Manufacturer;
//                selected.PhoneNumber = entity.PhoneNumber;
//                selected.Website = entity.Website;
//                selected.Email = entity.Email;
//                selected.Adress = entity.Adress;
//                db.Entry(selected).State = EntityState.Modified;
//                db.SaveChanges();
//                return true;
//            }
//            return false;

//        }

//        public IEnumerable<ManufacturerContact> getAll()
//        {
//            return db.ManufacturerContacts;

//        }

//        public ManufacturerContact GetById(int id)
//        {
//            return db.ManufacturerContacts.Find(id);
//        }

//        public void Remove(int id)
//        {
//            ManufacturerContact ManufacturerContacts = GetById(id);
//            if (ManufacturerContacts != null)
//            {
//                db.ManufacturerContacts.Remove(ManufacturerContacts);
//                db.SaveChanges();
//            }

//        }
//        private bool disposedValue = false;
//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposedValue)
//            {
//                if (disposing)
//                {
//                    // TODO: dispose managed state
//                    db.Dispose();
//                }
//                disposedValue = true;
//            }
//        }
//        public void Dispose()
//        {
//            Dispose(true);
//        }
//    }
//}

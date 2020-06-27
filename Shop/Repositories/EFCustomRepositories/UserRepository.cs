using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.EFCustomRepositories
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Models;
    using Shop.Repositories.Interfaces;

    public class UserRepository : IUserRepository
    {
        //private readonly StoreContext db;
        readonly StoreContext db;
        public UserRepository(StoreContext context)
        {
            this.db = context;
        }
        public void Add(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();

        }

        public bool Edit(User entity)
        {
            User selected = GetById(entity.Id);
            if (selected != null)
            {
                selected.Name = entity.Name;
                selected.Surname = entity.Surname;
                selected.Email = entity.Email;
                selected.Login = entity.Login;
                selected.Password = entity.Password;
                selected.Phone = entity.Phone;
                selected.UserComments = entity.UserComments;
                selected.UsersPurchases = entity.UsersPurchases;

                db.Entry(selected).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<User>> getAll()
        {
            return await db.Users.ToListAsync();

        }

        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public void Remove(int id)
        {
            User User = GetById(id);
            if (User != null)
            {
                db.Users.Remove(User);
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

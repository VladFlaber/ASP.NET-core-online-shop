using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.EFCustomRepositories
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Models;
    using Shop.Repositories.Interfaces;

    public class UserCommentRepository : IUserCommentRepository 
    {
        //private readonly StoreContext db;
        readonly StoreContext db;
        public UserCommentRepository(StoreContext context)
        {
            this.db = context;
        }
        public void Add(UserComment entity)
        {
            db.UserComments.Add(entity);
            db.SaveChanges();

        }

        public bool Edit(UserComment entity)
        {
            UserComment selected = GetById(entity.Id);
            if (selected != null)
            {
                selected.Text = entity.Text;
                selected.Product = entity.Product;
                selected.User = entity.User;
                
                db.Entry(selected).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<UserComment>> getAll()
        {
            return await db.UserComments.ToListAsync();

        }

        public UserComment GetById(int id)
        {
            return db.UserComments.Find(id);
        }

        public void Remove(int id)
        {
            UserComment UserComment = GetById(id);
            if (UserComment != null)
            {
                db.UserComments.Remove(UserComment);
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

using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> getAll();
        void Add(User entity);
        void Remove(int id);
        bool Edit(User entity);
        User GetById(int id);
    }
}

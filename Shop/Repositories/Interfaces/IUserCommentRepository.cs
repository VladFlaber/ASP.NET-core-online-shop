using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
    public interface IUserCommentRepository
    {
        Task<IEnumerable<UserComment>> getAll();
        void Add(UserComment entity);
        void Remove(int id);
        bool Edit(UserComment entity);
        UserComment GetById(int id);
    }
}

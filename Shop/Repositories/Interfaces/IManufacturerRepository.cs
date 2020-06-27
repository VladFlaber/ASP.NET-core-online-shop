using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
    public interface IManufacturerRepository
    {

        Task<IEnumerable<Manufacturer>> getAll();
        void Add(Manufacturer entity);
        void Remove(int id);
        bool Edit(Manufacturer entity);
        Manufacturer GetById(int id);
    }
}

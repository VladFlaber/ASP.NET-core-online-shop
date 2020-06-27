using Shop.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Categories { get; }
        ISubCategoryRepository SubCategories { get; }
        IProductImageRepository ProductImages{ get; }
        IProductRepository Products{ get; }
        IManufacturerRepository Manufacturers{ get; }
        Task Save();

    }
}

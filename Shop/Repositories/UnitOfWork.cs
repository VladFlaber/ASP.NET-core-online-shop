using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Repositories.EFCustomRepositories;
using Shop.Repositories.Interfaces;

namespace Shop.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(StoreContext context)
        {
            db = context;
        }
        private readonly StoreContext db;
        private IProductRepository productRepo;
       
        public IProductRepository Products
        {
            get
            {
                if (productRepo == null)
                    productRepo = new ProductRepository(db);
                return productRepo;
            }
        }
        private ICategoryRepository categoriesRepo;
        public ICategoryRepository Categories
        {
            get
            {
                if (categoriesRepo == null)
                    categoriesRepo = new CategoryRepository(db);
                return categoriesRepo;
            }
        }
        private ISubCategoryRepository subcategoryRepo;
        public ISubCategoryRepository SubCategories
        {
            get
            {
                if (subcategoryRepo == null)
                    subcategoryRepo = new SubCategoryRepository(db);
                return subcategoryRepo;
            }
        }
        private IManufacturerRepository manufacturerRepository;
        public IManufacturerRepository Manufacturers
        {
            get
            {
                if (manufacturerRepository == null)
                    manufacturerRepository = new ManufacturerRepository(db);
                return manufacturerRepository;
            }
        }
        private IProductImageRepository productImageRepository;
        public IProductImageRepository ProductImages
        {
            get
            {
               return productImageRepository = productImageRepository ?? new ProductImageRepository(db);            
            }
        }

       

        public async Task Save() { await db.SaveChangesAsync(); }




        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

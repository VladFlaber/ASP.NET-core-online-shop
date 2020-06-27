namespace Shop.Models
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    public class StoreContext : DbContext
    {
        /// <summary>
        /// presetnts the upper level of categories of prouducts. Category-> SubCategory->Product
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// presetns the lower level of categories of products. Category-> SubCategory->Product
        /// </summary>
        public DbSet<SubCategory> SubCategories { get; set; }
        /// <summary>
        /// Presents products that online - store has
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Presents customers that already have an account .
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Presents list of commentaries that one user published
        /// </summary>
        public DbSet<UserComment> UserComments { get; set; }
        /// <summary>
        /// Presents the manufacturer that produce one products
        /// </summary>
        public DbSet<Manufacturer> Manufacturers { get; set; }
        /// <summary>
        /// Presents the contacts list of one manufacturer
        /// </summary>
        public DbSet<ManufacturerContact> ManufacturerContacts { get; set; }
        /// <summary>
        /// Presetnts the list of images of  one product
        /// </summary>
        public DbSet<ProductImage> ProductImages{ get; set; }
        //  public DbSet<Purchase> Purchases { get; set; }
        // public DbSet<ProductStorage> ProductStorages { get; set; }
        //   public DbSet<ProductsPurasches>ProductsPurasches{ get; set; }

            //public DbSet<Order> Orders { get; set; }
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
            Database.EnsureCreated();
            
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //}
    }
}
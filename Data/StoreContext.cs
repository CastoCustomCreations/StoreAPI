using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        // Define DbSets for your tables here
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        // Override OnModelCreating to configure the decimal properties
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure precision for decimal properties in the Product entity
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);  // Example: Precision 18, Scale 2

            modelBuilder.Entity<Product>()
                .Property(p => p.UnitCost)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Product>()
                .Property(p => p.UnitWeight)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}

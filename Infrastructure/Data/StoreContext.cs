using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions <StoreContext> options) : base(options)
        {
            
        }
          protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
    {
        optionbuilder.UseSqlite(@"Data Source=Skinet.db");
        SQLitePCL.Batteries.Init();
    }
        public DbSet<Product> Products { get; set; } 
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
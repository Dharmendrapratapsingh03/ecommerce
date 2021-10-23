using Core.Entities;
using Microsoft.EntityFrameworkCore;


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
    }
}
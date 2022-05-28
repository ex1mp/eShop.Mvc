using eShop.Mvc.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShop.Mvc.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<CatalogItem> Catalog { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<OrderItem> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductKey> ProductKeys { get; set; }
        public DbSet<SystemRequirments> SystemRequirments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (local)\\SQLEXPRESS; Database = eShop; Trusted_Connection = True; MultipleActiveResultSets = true");
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        //}
    }
}

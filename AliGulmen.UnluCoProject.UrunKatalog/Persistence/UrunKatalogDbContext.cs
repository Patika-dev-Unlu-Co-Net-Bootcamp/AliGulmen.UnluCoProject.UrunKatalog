using AliGulmen.UnluCoProject.UrunKatalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence
{
    public class UrunKatalogDbContext : DbContext
    {
        public UrunKatalogDbContext(DbContextOptions<UrunKatalogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
        public DbSet<User> Users { get; set; }
   
    }
}

using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(UrunKatalogDbContext context) : base(context)
        {
        }
    }
}

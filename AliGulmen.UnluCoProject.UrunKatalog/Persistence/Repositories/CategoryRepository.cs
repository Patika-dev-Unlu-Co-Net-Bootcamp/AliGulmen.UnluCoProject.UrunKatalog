using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(UrunKatalogDbContext context) : base(context)
        {
        }
    }
}

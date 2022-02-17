using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public class PurchaseHistoryRepository : Repository<PurchaseHistory>, IPurchaseHistoryRepository
    {
        public PurchaseHistoryRepository(UrunKatalogDbContext context) : base(context)
        {
        }
    }
}

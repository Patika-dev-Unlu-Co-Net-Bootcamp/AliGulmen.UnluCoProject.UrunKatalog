using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public class OfferRepository : Repository<Offer>, IOfferRepository
    {
        public OfferRepository(UrunKatalogDbContext context) : base(context)
        {
        }
    }
}

using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IOfferRepository : IRepository<Offer>
    {
        Task<IEnumerable<Offer>> GetMyOffers(string userId);
        Task<IEnumerable<Offer>> GetMyProducts(string userId);
    }
}

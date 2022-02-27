using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task CreateSellInformation(PurchaseHistory purchaseInfo);
        Task BuyWithOffer(int id);
    }
}

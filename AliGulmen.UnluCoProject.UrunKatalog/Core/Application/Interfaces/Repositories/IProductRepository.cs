using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task CreateSellInformation(PurchaseHistory purchaseInfo);
    }
}

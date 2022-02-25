using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IPurchaseHistoryRepository : IRepository<PurchaseHistory>
    {
        Task<IEnumerable<PurchaseHistory>> GetAllSold(string userId);
        Task<IEnumerable<PurchaseHistory>> GetAllPurchased(string userId);
    }
}

using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllWithQuery(Filter filter);

    }
}

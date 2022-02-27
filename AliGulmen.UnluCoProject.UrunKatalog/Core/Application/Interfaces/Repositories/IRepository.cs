using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);

        Task<PaginatedResult<TEntity>> GetAll(Filter filter);

        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}

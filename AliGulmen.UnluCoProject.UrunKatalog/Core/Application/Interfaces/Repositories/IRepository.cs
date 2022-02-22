using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);

        Task<IEnumerable<TEntity>> GetAll();

        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}

using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private readonly UrunKatalogDbContext _context;
    

    public Repository(UrunKatalogDbContext context)
        {
            
            _context = context;
        }
       
      //we use abstract for gets here because every model has different includes
        public void Add(TEntity entity)
        {

            _context.Set<TEntity>().Add(entity);
        }


        public void Remove(TEntity entity)
        {
           _context.Set<TEntity>().Remove(entity);
        }

        public abstract Task<TEntity> Get(int id);

        public abstract Task<IEnumerable<TEntity>> GetAll();
    }
}

using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
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
       
        public async Task<TEntity> Get(int id)
        {
            var result = await _context.Set<TEntity>().FindAsync(id);

            if (result == null)
                throw new KeyNotFoundException("Not Found!");


            return result;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public void Add(TEntity entity)
        {

            _context.Set<TEntity>().Add(entity);
        }


        public void Remove(TEntity entity)
        {
           _context.Set<TEntity>().Remove(entity);
        }
    }
}

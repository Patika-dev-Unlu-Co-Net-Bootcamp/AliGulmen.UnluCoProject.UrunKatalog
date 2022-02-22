using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly UrunKatalogDbContext _context;

        public ProductRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Product> Get(int id)
        {
            var result = await _context.Products
                                .Include(p => p.Color)
                                .Include(p => p.Brand)
                                .Include(p => p.Condition)
                                .Include(p => p.Category)
                                .Include(p => p.User)
                                .FirstOrDefaultAsync(p => p.Id == id);



            if (result == null)
                throw new KeyNotFoundException("Not Found!");



            return result;
        }

      

        public override async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products
                                .Include(p => p.Color)
                                .Include(p => p.Brand)
                                .Include(p => p.Condition)
                                .Include(p => p.Category)
                                .Include(p => p.User)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllWithQuery(Filter filter)
        {
            var query =  _context.Products
                                .Include(p => p.Color)
                                .Include(p => p.Brand)
                                .Include(p => p.Condition)
                                .Include(p => p.Category)
                                .Include(p => p.User)
                .AsQueryable();

            if (filter.CategoryId.HasValue)
                query = query.Where(p => p.CategoryId == filter.CategoryId.Value);

            return await query.ToListAsync();
        }
    }
}

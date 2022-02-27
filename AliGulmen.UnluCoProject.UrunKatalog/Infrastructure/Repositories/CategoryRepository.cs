using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly UrunKatalogDbContext _context;

        public CategoryRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Category> Get(int id)
        {
            var result = await _context.Categories
                                .FirstOrDefaultAsync(p => p.Id == id);

            if (result == null)
                throw new KeyNotFoundException("Not Found!");

            return result;
        }



        public override async Task<PaginatedResult<Category>> GetAll(Filter filter)
        {

            var query = _context.Categories.AsQueryable();

            var result = await query.ToPaginatedListAsync(filter.PageNumber, filter.PageSize);

            return result;

        }


    }
}

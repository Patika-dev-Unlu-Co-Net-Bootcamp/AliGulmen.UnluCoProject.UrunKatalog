using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        private readonly UrunKatalogDbContext _context;

        public BrandRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Brand> Get(int id)
        {
            var result = await _context.Brands
                                .FirstOrDefaultAsync(p => p.Id == id);



            if (result == null)
                throw new KeyNotFoundException("Not Found!");



            return result;
        }



        public override async Task<PaginatedResult<Brand>> GetAll(Filter filter)
        {

            var query = _context.Brands
               .AsQueryable();

               var result = await query.ToPaginatedListAsync(filter.PageNumber, filter.PageSize);


            return result;

        }


     

    }
}

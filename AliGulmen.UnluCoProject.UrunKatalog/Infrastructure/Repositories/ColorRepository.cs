using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class ColorRepository : Repository<Color>, IColorRepository
    {
        private readonly UrunKatalogDbContext _context;

        public ColorRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Color> Get(int id)
        {
            var result = await _context.Colors
                                .FirstOrDefaultAsync(p => p.Id == id);



            if (result == null)
                throw new KeyNotFoundException("Not Found!");



            return result;
        }



        public override async Task<PaginatedResult<Color>> GetAll(Filter filter)
        {

            var query = _context.Colors
               .AsQueryable();

            var result = await query.ToPaginatedListAsync(filter.PageNumber, filter.PageSize);


            return result;





        
        }


    }
}

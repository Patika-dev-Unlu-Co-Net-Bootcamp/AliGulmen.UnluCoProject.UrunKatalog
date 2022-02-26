using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class ConditionRepository : Repository<Condition>, IConditionRepository
    {
        private readonly UrunKatalogDbContext _context;

        public ConditionRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Condition> Get(int id)
        {
            var result = await _context.Conditions
                                .FirstOrDefaultAsync(p => p.Id == id);



            if (result == null)
                throw new KeyNotFoundException("Not Found!");



            return result;
        }



        public override async Task<PaginatedResult<Condition>> GetAll(Filter filter)
        {
            var query = _context.Conditions
             .AsQueryable();

          

            var result = await query.ToPaginatedListAsync(filter.PageNumber, filter.PageSize);


            return result;
        }

    }
}

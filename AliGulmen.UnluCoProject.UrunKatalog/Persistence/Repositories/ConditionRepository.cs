﻿using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
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



        public override async Task<IEnumerable<Condition>> GetAll()
        {
            return await _context.Conditions
                                 .ToListAsync();
        }


    }
}

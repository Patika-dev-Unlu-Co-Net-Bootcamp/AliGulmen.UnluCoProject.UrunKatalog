﻿using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;

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



        public override async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories
                .ToListAsync();
        }


    }
}
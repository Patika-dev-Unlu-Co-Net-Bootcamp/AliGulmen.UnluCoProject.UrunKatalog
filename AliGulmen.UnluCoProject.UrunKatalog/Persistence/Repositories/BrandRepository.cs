using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
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



        public override async Task<IEnumerable<Brand>> GetAll()
        {
            return await _context.Brands
                .ToListAsync();
        }

    }
}

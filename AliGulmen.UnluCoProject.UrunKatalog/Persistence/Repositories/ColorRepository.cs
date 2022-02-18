using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
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



        public override async Task<IEnumerable<Color>> GetAll()
        {
            return await _context.Colors
                .ToListAsync();
        }


    }
}

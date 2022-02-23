using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;
using System.Linq;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class OfferRepository : Repository<Offer>, IOfferRepository
    {
        private readonly UrunKatalogDbContext _context;

        public OfferRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Offer> Get(int id)
        {
            var result = await _context.Offers
                                .Include(p => p.Product)
                                .Include(p => p.User)
                                .FirstOrDefaultAsync(p => p.Id == id);



            if (result == null)
                throw new KeyNotFoundException("Not Found!");



            return result;
        }



        public override async Task<IEnumerable<Offer>> GetAll()
        {
            return await _context.Offers
                                 .Include(p => p.Product)
                                .Include(p => p.User)
                .ToListAsync();
        }

        public async Task<IEnumerable<Offer>> GetMyOffers(string userId)
        {
            return await _context.Offers
                                    .Include(p => p.Product)
                                    .Include(p => p.User)
                                    .Where(p => p.UserId == userId)
                                    .ToListAsync();
        }
    }
}

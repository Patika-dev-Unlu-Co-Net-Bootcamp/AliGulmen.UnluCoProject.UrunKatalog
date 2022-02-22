using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class PurchaseHistoryRepository : Repository<PurchaseHistory>, IPurchaseHistoryRepository
    {
        private readonly UrunKatalogDbContext _context;

        public PurchaseHistoryRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<PurchaseHistory> Get(int id)
        {
            var result = await _context.PurchaseHistories
                                .Include(p => p.Product)
                                .Include(p => p.Buyer)
                                .Include(p => p.Seller)
                                .FirstOrDefaultAsync(p => p.Id == id);



            if (result == null)
                throw new KeyNotFoundException("Not Found!");



            return result;
        }



        public override async Task<IEnumerable<PurchaseHistory>> GetAll()
        {
            return await _context.PurchaseHistories
                                  .Include(p => p.Product)
                                .Include(p => p.Buyer)
                                .Include(p => p.Seller)
                .ToListAsync();
        }

    }
}

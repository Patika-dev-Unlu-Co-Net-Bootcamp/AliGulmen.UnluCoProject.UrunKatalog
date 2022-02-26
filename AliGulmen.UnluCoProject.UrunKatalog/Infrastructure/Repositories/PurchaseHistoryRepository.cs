using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;
using System.Linq;
using System;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

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



        public override async Task<PaginatedResult<PurchaseHistory>> GetAll(Filter filter)
        {

            var query = _context.PurchaseHistories
                                .Include(p => p.Product)
                                .Include(p => p.Buyer)
                                .Include(p => p.Seller)
              .AsQueryable();





            var result = await query.ToPaginatedListAsync(filter.PageNumber, filter.PageSize);

            return result;
        }


        public async Task<IEnumerable<PurchaseHistory>> GetAllPurchased(string userId)
        {
            return await _context.PurchaseHistories
                                .Include(p => p.Product)
                                .Include(p => p.Buyer)
                                .Include(p => p.Seller)
                                .Where(p => p.BuyerId == userId)
                .ToListAsync();
        }


        public async Task<IEnumerable<PurchaseHistory>> GetAllSold(string userId)
        {
            return await _context.PurchaseHistories
                                  .Include(p => p.Product)
                                .Include(p => p.Buyer)
                                .Include(p => p.Seller)
                                 .Where(p => p.SellerId == userId)
                .ToListAsync();
        }

    }
}

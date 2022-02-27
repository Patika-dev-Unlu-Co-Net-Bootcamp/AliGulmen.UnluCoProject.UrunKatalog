using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly UrunKatalogDbContext _context;

        public ProductRepository(UrunKatalogDbContext context) : base(context)
        {
            _context = context;
        }

      
        public override async Task<Product> Get(int id)
        {
            var result = await _context.Products
                                .Include(p => p.Color)
                                .Include(p => p.Brand)
                                .Include(p => p.Condition)
                                .Include(p => p.Category)
                                .Include(p => p.User)
                                .FirstOrDefaultAsync(p => p.Id == id);

            if (result == null)
                throw new KeyNotFoundException("Not Found!");

            return result;
        }

      

        public override async Task<PaginatedResult<Product>> GetAll(Filter filter)
        {
            var query = _context.Products
                                .Include(p => p.Color)
                                .Include(p => p.Brand)
                                .Include(p => p.Condition)
                                .Include(p => p.Category)
                                .Include(p => p.User)
                                .AsQueryable();

            if (filter.CategoryId.HasValue)
                query = query.Where(p => p.CategoryId == filter.CategoryId.Value).AsQueryable();

            var result = await query.ToPaginatedListAsync(filter.PageNumber, filter.PageSize);

            return result;
        }




        public async Task CreateSellInformation(PurchaseHistory purchaseInfo)
        {
           await Task.Run(() => _context.PurchaseHistories.Add(purchaseInfo));
        }





        public async Task BuyWithOffer(int id)
        {
            //will do with stored procedure
            //  string StoredProc = "exec proc_BuyWithOffer " + "@offerId = " + id;
            SqlParameter param1 = new SqlParameter("@offerId", id);
            await Task.Run(() => _context.Database.ExecuteSqlRaw("exec proc_BuyWithOffer @offerId", param1));

        }
    }
}

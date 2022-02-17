using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UrunKatalogDbContext _context;

        public UnitOfWork(UrunKatalogDbContext context)
        {
            _context = context;
        }


        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

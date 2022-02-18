using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UrunKatalogDbContext _context;

        public UserRepository(UrunKatalogDbContext context) 
        {
            _context = context;
        }

       
        public async Task<AppUser> Get(string id)
        {
            var result = await _context.Users
                                 .FirstOrDefaultAsync(p => p.Id == id);



            if (result == null)
                throw new KeyNotFoundException("Not Found!");



            return result;
        }

        public async Task<IEnumerable<AppUser>> GetAll()
        {
            return await _context.Users
                .ToListAsync();
        }

        public void Remove(AppUser appUser)
        {
                _context.AppUser.Remove(appUser);
        }
    }
}

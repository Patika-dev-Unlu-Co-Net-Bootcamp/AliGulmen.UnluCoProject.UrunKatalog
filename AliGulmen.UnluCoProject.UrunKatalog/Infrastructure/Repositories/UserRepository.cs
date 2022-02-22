using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Context;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Repositories
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

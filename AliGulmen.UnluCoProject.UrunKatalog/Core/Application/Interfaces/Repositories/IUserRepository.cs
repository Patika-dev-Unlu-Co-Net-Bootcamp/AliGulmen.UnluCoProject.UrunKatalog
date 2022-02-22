using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{
    public interface IUserRepository 
    {
        Task<AppUser> Get(string id);
        Task<IEnumerable<AppUser>> GetAll();

        void Remove(AppUser appUser);
       
    }
}

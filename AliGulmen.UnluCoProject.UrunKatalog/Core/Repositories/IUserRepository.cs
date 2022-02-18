using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories
{
    public interface IUserRepository 
    {
        Task<AppUser> Get(string id);
        Task<IEnumerable<AppUser>> GetAll();

        void Remove(AppUser appUser);
       
    }
}

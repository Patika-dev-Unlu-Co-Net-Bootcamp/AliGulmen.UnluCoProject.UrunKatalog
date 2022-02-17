using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UrunKatalogDbContext context) : base(context)
        {
        }
    }
}

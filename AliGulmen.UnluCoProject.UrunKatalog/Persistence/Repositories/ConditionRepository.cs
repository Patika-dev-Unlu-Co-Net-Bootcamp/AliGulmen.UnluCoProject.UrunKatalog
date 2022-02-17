using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence.Repositories
{
    public class ConditionRepository : Repository<Condition>, IConditionRepository
    {
        public ConditionRepository(UrunKatalogDbContext context) : base(context)
        {
        }
    }
}

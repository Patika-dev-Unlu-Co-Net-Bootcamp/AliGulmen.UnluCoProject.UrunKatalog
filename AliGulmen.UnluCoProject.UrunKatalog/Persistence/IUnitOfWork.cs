using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence
{


    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}

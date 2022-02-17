using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core
{


    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}

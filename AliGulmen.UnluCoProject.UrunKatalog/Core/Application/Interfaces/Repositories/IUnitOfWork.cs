using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories
{


    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}

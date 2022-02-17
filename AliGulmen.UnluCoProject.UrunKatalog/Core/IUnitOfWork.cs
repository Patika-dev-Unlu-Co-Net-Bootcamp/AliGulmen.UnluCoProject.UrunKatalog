using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{


    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}

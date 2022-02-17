using AliGulmen.UnluCoProject.UrunKatalog.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategory(int id);

        void Add(Category category);
        void Remove(Category category);
        Task<List<Category>> GetCategories();
    }
}
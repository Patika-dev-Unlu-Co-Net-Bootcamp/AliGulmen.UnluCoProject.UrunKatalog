using AliGulmen.UnluCoProject.UrunKatalog.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Persistence
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly UrunKatalogDbContext _context;

        public CategoryRepository(UrunKatalogDbContext context)
        {
            _context = context;
        }

        public async Task<Category> GetCategory(int id)
        {
      
            return await _context.Categories.FindAsync(id);


        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
        }


        public async Task<List<Category>> GetCategories()
        {

            return  await _context.Categories.ToListAsync();


        }

        public void Remove(Category category)
        {
            _context.Categories.Remove(category);
        }

    }
}

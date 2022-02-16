using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers
{
    [Route("api/Categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly UrunKatalogDbContext _context;
        private readonly IMapper _mapper;
        public CategoryController(UrunKatalogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetCategories()
        {
           var categories = await _context.Categories.ToListAsync();
            
            return _mapper.Map<List<Category>, List<CategoryResource>>(categories);
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<CreateCategoryResource, Category>(categoryResource);
            _context.Categories.Add(result);
            await _context.SaveChangesAsync();
           return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, CreateCategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var category = await _context.Categories.FindAsync(id);

            if (category == null)
                return NotFound();

            var result = _mapper.Map<CreateCategoryResource, Category>(categoryResource, category);
          
            await _context.SaveChangesAsync();
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
          
            var category = await _context.Categories.FindAsync(id);
            
            if(category == null)
                return NotFound();

            _context.Remove(category);
            await _context.SaveChangesAsync();
            return Ok(id);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {

            var category = await _context.Categories.FindAsync(id);

            if (category == null)
                return NotFound();

           var categoryResource = _mapper.Map<Category, CategoryResource>(category);
            return Ok(categoryResource);
        }
    }
}

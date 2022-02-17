using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers
{
    [Route("api/Categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryController(UrunKatalogDbContext context, IMapper mapper, ICategoryRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetCategories()
        {
            var categories = await _repository.GetCategories();
            
            return _mapper.Map<List<Category>, List<CategoryResource>>(categories);
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(SaveCategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveCategoryResource, Category>(categoryResource);
            _repository.Add(result);
            await _unitOfWork.CompleteAsync();
           return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, SaveCategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var category = await _repository.GetCategory(id);

            if (category == null)
                return NotFound();

            var result = _mapper.Map<SaveCategoryResource, Category>(categoryResource, category);
          
            await _unitOfWork.CompleteAsync();
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {

            var category = await _repository.GetCategory(id);

            if (category == null)
                return NotFound();

           _repository.Remove(category);
            await _unitOfWork.CompleteAsync();
            return Ok(id);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _repository.GetCategory(id);
          
            if (category == null)
                return NotFound();

           var categoryResource = _mapper.Map<Category, CategoryResource>(category);
            return Ok(categoryResource);
        }
    }
}

using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.CategoryResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryController(IMapper mapper, ICategoryRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }




        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetCategories()
        {
            var categories = await _repository.GetAll();
            var result = _mapper.Map<List<Category>, List<CategoryResource>>(categories.ToList());
            return result;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _repository.Get(id);
            var categoryResource = _mapper.Map<Category, CategoryResource>(category);
            return Ok(categoryResource);
        }





        [HttpPost]
        public async Task<IActionResult> CreateCategory(SaveCategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveCategoryResource, Category>(categoryResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/categories", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, SaveCategoryResource categoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var category = await _repository.Get(id);
            _mapper.Map<SaveCategoryResource, Category>(categoryResource, category);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {

            var category = await _repository.Get(id);
            _repository.Remove(category);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }



    }
}

﻿using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.CategoryResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers
{

    [Route("api/categories")]
    [Authorize]
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
        public async Task<PaginatedResult<CategoryResource>> GetProducts([FromQuery] FilterResource filterResource)
        {
            var filter = _mapper.Map<FilterResource, Filter>(filterResource);
            var categories = await _repository.GetAll(filter);

            var result = _mapper.Map<PaginatedResult<Category>, PaginatedResult<CategoryResource>>(categories);

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

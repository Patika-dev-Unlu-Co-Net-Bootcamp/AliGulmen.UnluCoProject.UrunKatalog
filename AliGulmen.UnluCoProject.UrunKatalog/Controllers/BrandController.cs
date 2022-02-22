using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.BrandResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BrandController(IMapper mapper, IBrandRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IEnumerable<BrandResource>> GetBrands()
        {
            var brands = await _repository.GetAll();
            var result = _mapper.Map<List<Brand>, List<BrandResource>>(brands.ToList());
            return result;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var brand = await _repository.Get(id);
            var brandResource = _mapper.Map<Brand, BrandResource>(brand);
            return Ok(brandResource);
        }





        [HttpPost]
        public async Task<IActionResult> CreateBrand(SaveBrandResource brandResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveBrandResource, Brand>(brandResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/brands", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, SaveBrandResource brandResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var brand = await _repository.Get(id);
            _mapper.Map<SaveBrandResource, Brand>(brandResource, brand);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {

            var brand = await _repository.Get(id);
            _repository.Remove(brand);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


    }
}

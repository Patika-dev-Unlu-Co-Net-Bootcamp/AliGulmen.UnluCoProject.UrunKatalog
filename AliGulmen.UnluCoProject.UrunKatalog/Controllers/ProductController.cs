using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.ProductResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper, IProductRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }




        [HttpGet]
        public async Task<IEnumerable<ProductResource>> GetProducts()
        {
            var products = await _repository.GetAll();
            var result = _mapper.Map<List<Product>, List<ProductResource>>(products.ToList());
         
            return result;
        }

        [HttpGet("/withFilter")]
        public async Task<IEnumerable<ProductResource>> GetProductsWithQuery([FromQuery]FilterResource filterResource)
        {
            var filter = _mapper.Map<FilterResource, Filter>(filterResource);
            var products = await _repository.GetAllWithQuery(filter);

            var result = _mapper.Map<List<Product>, List<ProductResource>>(products.ToList());

            return result;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _repository.Get(id);
            
            var productResource = _mapper.Map<Product, ProductResource>(product);
            return Ok(productResource);
        }





        [HttpPost]
        public async Task<IActionResult> CreateProduct(SaveProductResource productResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveProductResource, Product>(productResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/products", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, SaveProductResource productResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var product = await _repository.Get(id);
            _mapper.Map<SaveProductResource, Product>(productResource, product);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {

            var product = await _repository.Get(id);
            _repository.Remove(product);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }



    }
}

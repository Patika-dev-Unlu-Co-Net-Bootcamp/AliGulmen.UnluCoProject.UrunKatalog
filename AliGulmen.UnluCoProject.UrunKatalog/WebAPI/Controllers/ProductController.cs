using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ProductResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;
using Microsoft.AspNetCore.Authorization;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.PurchaseHistoryResources;
using System;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    [Authorize]
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



        [AllowAnonymous]
        [HttpGet]
        public async Task<PaginatedResult<ProductResource>> GetProducts([FromQuery] FilterResource filterResource)
        {
            var filter = _mapper.Map<FilterResource, Filter>(filterResource);
            var products = await _repository.GetAll(filter);

            var result = _mapper.Map<PaginatedResult<Product>, PaginatedResult<ProductResource>>(products);

            return result;
        }





        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute]int id)
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


        [HttpPut("Sell/{id}")]
        public async Task<IActionResult> SellProduct(int id, [FromBody] string userId)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var product = await _repository.Get(id);
            SavePurchaseHistoryResource purchaseInfo = new();
            purchaseInfo.ProductId = product.Id;
            purchaseInfo.BuyerId = userId;
            purchaseInfo.SellerId = product.UserId;
            purchaseInfo.PurchasedDate = DateTime.Now;
            purchaseInfo.SoldPrice = product.BuyItNowPrice;

            var result = _mapper.Map<SavePurchaseHistoryResource, PurchaseHistory>(purchaseInfo);

             await _repository.CreateSellInformation(result);
           

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


        [HttpPost("BuyWithOffer")]
        public async Task<IActionResult> BuyWithOffer([FromBody]int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();


            //will do with stored procedure
            await _repository.BuyWithOffer(id);
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

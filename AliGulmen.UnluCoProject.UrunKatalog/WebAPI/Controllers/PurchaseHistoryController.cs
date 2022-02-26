using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.PurchaseHistoryResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers
{
    [Route("api/PurchaseHistories")]
    [ApiController]
    [Authorize]
    public class PurchaseHistoryController : ControllerBase
    {
        private readonly IPurchaseHistoryRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public PurchaseHistoryController(IMapper mapper, IPurchaseHistoryRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }




        [HttpPost("purchased")]
        public async Task<IEnumerable<PurchaseHistoryResource>> GetPurchaseHistories([FromBody] string userId)
        {
            var purchaseHistories = await _repository.GetAllPurchased(userId);
            var result = _mapper.Map<List<PurchaseHistory>, List<PurchaseHistoryResource>>(purchaseHistories.ToList());
            return result;
        }


        [HttpPost("sold")]
        public async Task<IEnumerable<PurchaseHistoryResource>> GetSoldHistories([FromBody] string userId)
        {
            var purchaseHistories = await _repository.GetAllSold(userId);
            var result = _mapper.Map<List<PurchaseHistory>, List<PurchaseHistoryResource>>(purchaseHistories.ToList());
            return result;
        }




        [HttpGet("{id}")]
        public async Task<IActionResult> GetPurchaseHistory(int id)
        {
            var purchaseHistory = await _repository.Get(id);
            var purchaseHistoryResource = _mapper.Map<PurchaseHistory, PurchaseHistoryResource>(purchaseHistory);
            return Ok(purchaseHistoryResource);
        }





        [HttpPost]
        public async Task<IActionResult> CreatePurchaseHistory(SavePurchaseHistoryResource purchaseHistoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SavePurchaseHistoryResource, PurchaseHistory>(purchaseHistoryResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/purchaseHistories", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePurchaseHistory(int id, SavePurchaseHistoryResource purchaseHistoryResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var purchaseHistory = await _repository.Get(id);
            _mapper.Map<SavePurchaseHistoryResource, PurchaseHistory>(purchaseHistoryResource, purchaseHistory);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseHistory(int id)
        {

            var purchaseHistory = await _repository.Get(id);
            _repository.Remove(purchaseHistory);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


    }
}

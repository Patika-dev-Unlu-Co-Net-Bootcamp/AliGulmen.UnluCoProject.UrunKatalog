using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [Authorize]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OfferController(IMapper mapper, IOfferRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }




        [HttpGet]
        public async Task<PaginatedResult<OfferResource>> GetProducts([FromQuery] FilterResource filterResource)
        {
            var filter = _mapper.Map<FilterResource, Filter>(filterResource);
            var offers = await _repository.GetAll(filter);

            var result = _mapper.Map<PaginatedResult<Offer>, PaginatedResult<OfferResource>>(offers);

            return result;
        }




        [HttpGet("{id}")]
        public async Task<IActionResult> GetOffer(int id)
        {
            var offer = await _repository.Get(id);
            var offerResource = _mapper.Map<Offer, OfferResource>(offer);
            return Ok(offerResource);
        }





        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateOffer(SaveOfferResource offerResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveOfferResource, Offer>(offerResource);

            var isOfferable = await _repository.IsOfferable(result);
            if (isOfferable)
                _repository.Add(result);
            else
                return BadRequest();


            await _unitOfWork.CompleteAsync();
            return Created("~api/offers", result);
        }





        [HttpPost("/api/myOffers")]
        public async Task<IActionResult> GetMyOffers([FromBody] string userId)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var offers = await _repository.GetMyOffers(userId);
            var offerResource = _mapper.Map<List<Offer>, List<OfferResource>>(offers.ToList());
            return Ok(offerResource);
        }



        [HttpPost("/api/myProducts")]
        public async Task<IActionResult> GetMyProducts([FromBody] string userId)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var offers = await _repository.GetMyProducts(userId);
            var offerResource = _mapper.Map<List<Offer>, List<OfferResource>>(offers.ToList());
            return Ok(offerResource);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOffer(int id, [FromBody] UpdateOfferResource newOffer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var offer = await _repository.Get(id);
            _mapper.Map<UpdateOfferResource, Offer>(newOffer, offer);
            await _unitOfWork.CompleteAsync();
            return NoContent();
        }





        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffer(int id)
        {

            var offer = await _repository.Get(id);
            _repository.Remove(offer);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


    }
}

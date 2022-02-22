using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.OfferResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers
{
    [Route("api/[controller]s")]
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
        public async Task<IEnumerable<OfferResource>> GetOffers()
        {
            var offers = await _repository.GetAll();
            var result = _mapper.Map<List<Offer>, List<OfferResource>>(offers.ToList());
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
        public async Task<IActionResult> CreateOffer(SaveOfferResource offerResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveOfferResource, Offer>(offerResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/offers", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOffer(int id, SaveOfferResource offerResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var offer = await _repository.Get(id);
            _mapper.Map<SaveOfferResource, Offer>(offerResource, offer);

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

using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.ColorResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Repositories;
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
    public class ColorController : ControllerBase
    {

        private readonly IColorRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ColorController(IMapper mapper, IColorRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }




        [HttpGet]
        public async Task<IEnumerable<ColorResource>> GetColors()
        {
            var colors = await _repository.GetAll();
            var result = _mapper.Map<List<Color>, List<ColorResource>>(colors.ToList());
            return result;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor(int id)
        {
            var color = await _repository.Get(id);
            var colorResource = _mapper.Map<Color, ColorResource>(color);
            return Ok(colorResource);
        }





        [HttpPost]
        public async Task<IActionResult> CreateColor(SaveColorResource colorResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveColorResource, Color>(colorResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/colors", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateColor(int id, SaveColorResource colorResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var color = await _repository.Get(id);
            _mapper.Map<SaveColorResource, Color>(colorResource, color);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {

            var color = await _repository.Get(id);
            _repository.Remove(color);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


    }

}

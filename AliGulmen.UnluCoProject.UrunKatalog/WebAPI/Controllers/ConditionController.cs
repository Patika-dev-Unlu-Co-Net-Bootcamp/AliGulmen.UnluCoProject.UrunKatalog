using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.ConditionResources;
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
    public class ConditionController : ControllerBase
    {
        private readonly IConditionRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ConditionController(IMapper mapper, IConditionRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }




        [HttpGet]
        public async Task<IEnumerable<ConditionResource>> GetConditions()
        {
            var conditions = await _repository.GetAll();
            var result = _mapper.Map<List<Condition>, List<ConditionResource>>(conditions.ToList());
            return result;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetCondition(int id)
        {
            var condition = await _repository.Get(id);
            var conditionResource = _mapper.Map<Condition, ConditionResource>(condition);
            return Ok(conditionResource);
        }





        [HttpPost]
        public async Task<IActionResult> CreateCondition(SaveConditionResource conditionResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveConditionResource, Condition>(conditionResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/conditions", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCondition(int id, SaveConditionResource conditionResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var condition = await _repository.Get(id);
            _mapper.Map<SaveConditionResource, Condition>(conditionResource, condition);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCondition(int id)
        {

            var condition = await _repository.Get(id);
            _repository.Remove(condition);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


    }
}


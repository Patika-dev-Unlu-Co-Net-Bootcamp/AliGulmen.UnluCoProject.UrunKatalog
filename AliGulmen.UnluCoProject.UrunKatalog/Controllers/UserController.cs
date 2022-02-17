using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.UserResources;
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
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UserController(IMapper mapper, IUserRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }




        [HttpGet]
        public async Task<IEnumerable<UserResource>> GetUsers()
        {
            var users = await _repository.GetAll();
            var result = _mapper.Map<List<User>, List<UserResource>>(users.ToList());
            return result;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repository.Get(id);
            var userResource = _mapper.Map<User, UserResource>(user);
            return Ok(userResource);
        }





        [HttpPost]
        public async Task<IActionResult> CreateUser(SaveUserResource userResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<SaveUserResource, User>(userResource);
            _repository.Add(result);

            await _unitOfWork.CompleteAsync();
            return Created("~api/users", result);
        }





        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, SaveUserResource userResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _repository.Get(id);
            _mapper.Map<SaveUserResource, User>(userResource, user);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {

            var user = await _repository.Get(id);
            _repository.Remove(user);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


    }
}

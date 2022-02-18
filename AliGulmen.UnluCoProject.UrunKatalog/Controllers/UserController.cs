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
            var result = _mapper.Map<List<AppUser>, List<UserResource>>(users.ToList());
            return result;
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(string id)
        {
            var user = await _repository.Get(id);
            var userResource = _mapper.Map<AppUser, UserResource>(user);
            return Ok(userResource);
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, SaveUserResource userResource)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var user = await _repository.Get(id);
            _mapper.Map<SaveUserResource, AppUser>(userResource, user);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {

            var user = await _repository.Get(id);
            _repository.Remove(user);

            await _unitOfWork.CompleteAsync();
            return NoContent();
        }


    }
}

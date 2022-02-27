using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.DTOs.Requests;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.DTOs.Responses;
using AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Services;
using EmailService.Domain;
using EmailService.Services;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly TokenGenerator _tokenGenerator;

        private readonly IEmailSender _emailSender;
        private readonly IBackgroundJobClient _backgroundJobClient;


        public AuthManagementController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, TokenGenerator tokenGenerator, IEmailSender emailSender, IBackgroundJobClient backgroundJobClient)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenGenerator = tokenGenerator;
            _emailSender = emailSender;
            _backgroundJobClient = backgroundJobClient;
        }





        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            if (ModelState.IsValid)
            {
                
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser != null)
                {
                    return  BadRequest(new RegistrationResponse()
                    {
                        Errors = "Email already in use",
                        Success = false
                    });
                }

                var newUser = new AppUser() { 
                    Email = user.Email, 
                    UserName = user.Username,
                    FirstName = user.FirstName,
                    LastName = user.LastName,   
                    Gender = Core.Domain.Enums.Gender.MALE

                };
                var isCreated = await _userManager.CreateAsync(newUser, user.Password);
                if (isCreated.Succeeded)
                {
                    var jwtToken = _tokenGenerator.CreateToken(newUser);


                    var message = new Message(user.Email, "UrunKatalog Uygulamasına Hoşgeldiniz!", "Üyeliğiniz gerçekleştirilmiştir, aramıza hoşgeldiniz");
                    _backgroundJobClient.Enqueue<IEmailSender>(x => x.SendEmailAsync(message));

                    return Ok(new RegistrationResponse()
                    {
                        Success = true,
                        Token = jwtToken
                    });
                }
                else
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = isCreated.Errors.Select(x => x.Description).FirstOrDefault(),
                        Success = false
                    });
                }
            }

            return BadRequest(new RegistrationResponse()
            {
                Errors = "Geçersiz Bilgiler!",
                Success = false
            });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser == null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = "Hatalı Mail Adresi Girdiniz!",
                        Success = false
                    });
                }
                if (await _userManager.IsLockedOutAsync(existingUser))
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = "Çok fazla başarısız giriş denemesi. Hesabınız 24 saatliğine bloke edilmiştir.",
                        Success = false
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

                if (!isCorrect)
                {
                   
                        await _userManager.AccessFailedAsync(existingUser);


                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = "Hatalı Şifre",
                        Success = false
                    });
                }

              



                var jwtToken = _tokenGenerator.CreateToken(existingUser);

                return Ok(new RegistrationResponse()
                {
                    Success = true,
                    Token = jwtToken
                });
            }

            return BadRequest(new RegistrationResponse()
            {
                Errors = "Geçersiz Modelstate!",
                Success = false
            });
        }

      
    }

}

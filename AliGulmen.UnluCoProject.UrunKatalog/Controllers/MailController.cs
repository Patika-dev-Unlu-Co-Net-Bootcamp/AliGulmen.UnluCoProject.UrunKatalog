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
using EmailService;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class MailController : ControllerBase
    {

        private readonly IEmailSender _emailSender;

        public MailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpGet]
        public  IActionResult SendMail()
        {
            var message = new Message("aligulmen91@gmail.com","E-Ticaret Uygulaması","E-Ticaret Deneme maili!");
            _emailSender.SendEmailAsync(message);
            return Ok();
        }



    }
}

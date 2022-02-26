using Microsoft.AspNetCore.Mvc;
using EmailService;
using EmailService.Services;
using Hangfire;
using EmailService.Domain;
using Microsoft.AspNetCore.Authorization;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    [Authorize]
    public class MailController : ControllerBase
    {

        private readonly IEmailSender _emailSender;
        private readonly IBackgroundJobClient _backgroundJobClient;

        public MailController(IEmailSender emailSender, IBackgroundJobClient backgroundJobClient)
        {
            _emailSender = emailSender;
            _backgroundJobClient = backgroundJobClient;
        }

        [HttpGet]
        

        public IActionResult SendMail()
        {
            var message = new Message("aligulmen91@gmail.com","E-Ticaret Uygulaması","E-Ticaret Deneme maili!");
           // _emailSender.SendEmailAsync(message);
           // _backgroundJobClient.Schedule<IEmailSender> (x => x.SendEmailAsync(message), new DateTimeOffset(DateTime.Now));
            _backgroundJobClient.Enqueue<IEmailSender>(x => x.SendEmailAsync(message));
            return Ok();
        }



    }
}

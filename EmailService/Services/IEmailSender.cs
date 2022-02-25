using EmailService.Domain;
using System.Threading.Tasks;

namespace EmailService.Services
{
    public interface IEmailSender
    {

        Task SendEmailAsync(Message message);
    }
}

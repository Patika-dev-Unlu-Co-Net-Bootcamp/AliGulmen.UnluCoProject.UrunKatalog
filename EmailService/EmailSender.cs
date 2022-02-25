using EmailService.Configurations;
using EmailService.Domain;
using EmailService.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace EmailService
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _eMailConfig;
       
        public EmailSender(EmailConfiguration eMailConfig)
        {
            _eMailConfig = eMailConfig;
        }

        public async Task SendEmailAsync(Message message)
        {
           await CreateAndSendEmailMessage(message);

        }

        private async Task CreateAndSendEmailMessage(Message message)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(message.To);
            mail.From = new MailAddress(_eMailConfig.From);
            mail.Subject = message.Subject;
            mail.Body = message.Body;
            mail.IsBodyHtml = true;
            
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential(_eMailConfig.From, _eMailConfig.Password);
            smtp.Port = _eMailConfig.Port;
            smtp.Host = _eMailConfig.SMTPServer;
            smtp.EnableSsl = true;



            using (smtp)
            {
                await smtp.SendMailAsync(mail);
            }


        }

    }



}

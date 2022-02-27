using EmailService;
using EmailService.Configurations;
using EmailService.Domain;
using EmailService.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SendEmailAsyncTest
{
    public class SendEmailAsyncTest
    {
        [Fact]
            public async Task SendEmailAsync_ReturnsNothing_WhenMessageGiven()
            {
                Mock<IEmailSender> smtpClient = new Mock<IEmailSender>();

                var emailMock = new EmailConfiguration { From = "aligulmen91@gmail.com", Port=111, SMTPServer="111", UserName="unluco", Password="unluco"};
                Message messageMock = new Message("aligulmen91@gmail.com", "subject", "body");

                var eMailSender = new EmailSender(emailMock);


                await eMailSender.SendEmailAsync(messageMock);


                Assert.True(true);
            }
    }
}

using EmailService;
using EmailService.Domain;
using EmailService.Configurations;
using Xunit;

namespace EMailServiceTest
{
    public class CreateMailTest
    {
        [Fact]
        public void CreateEmail_ReturnsMailMessage_WhenMessageGiven()
        {
            var emailMock = new EmailConfiguration { From = "aligulmen91@gmail.com" };

            Message messageMock = new Message("aligulmen91@gmail.com","subject","body");

            //arrange

            var eMailSender = new EmailSender(emailMock);

            //act
           var mail = eMailSender.CreateEmail(messageMock);

            //assert
            Assert.NotNull(mail);
            
        }
    }
}

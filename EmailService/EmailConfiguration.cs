using System;
using System.Net.Mail;

namespace EmailService
{
    public class EmailConfiguration
    {
        public string From { get; set; }
        public string SMTPServer { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }


   
}

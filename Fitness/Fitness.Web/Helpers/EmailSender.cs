using System.Net.Mail;
using System.Net;

namespace Fitness.Web.Helpers
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "rumeysa.c0101@gmail.com"; //giriş yapmak için kullanılan mail
            var pw = "Test12345678!";

            var client = new SmtpClient("blackworld752@gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message
                                ));
        }
    }
}

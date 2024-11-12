
using System.Net.Mail;

namespace LeaveManagmentSystem.Web.Services
{
    public class EmailSender(IConfiguration configuration) : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromAdress = configuration["EmailSettings:DefaultEmailAddress"];
            var smtpServer = configuration["EmailSettings:Server"];
            var smtpPort =  Convert.ToInt32(configuration["EmailSettings:Port"]);
            var message = new MailMessage
            {
                From = new MailAddress(fromAdress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            
            message.To.Add(new MailAddress(fromAdress));

            using var client = new SmtpClient(smtpServer, smtpPort);
            await client.SendMailAsync(message);
        }
    }
}

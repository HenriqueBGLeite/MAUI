using AppTask.Models;
using System.Net.Mail;

namespace AppTask.Api.Libraries.Emails
{
    public class EmailAccessToken
    {
        private SmtpClient _smtp;

        public EmailAccessToken(SmtpClient smtp)
        {
            _smtp = smtp;
        }

        public void Send(UserModel userModel)
        {
            // TODO - Obter E-mail do AppSettings
            var mailMessage = new MailMessage()
            {
                From = new MailAddress("henribatista7@gmail.com"),
                Subject = "AppTask - Token de Acesso",
                Body = $"Esse é o seu token de acesso: {userModel.AccessToken}.",
                IsBodyHtml = true,
            };

            mailMessage.To.Add(userModel.Email);

            _smtp.Send(mailMessage);
        }
    }
}

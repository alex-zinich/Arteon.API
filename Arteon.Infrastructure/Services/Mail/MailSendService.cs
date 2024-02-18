using Arteon.Core.Services.Mail;
using Arteon.Infrastructure.Settings;
using MailKit.Net.Smtp;
using MimeKit;

namespace Arteon.Infrastructure.Services.Mail
{
    public class MailSendService : IMailSendService
    {
        private readonly MailSettings _settings;

        public MailSendService(MailSettings settings)
        {
            _settings = settings;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            MimeMessage emailMessage = new();

            emailMessage.From.Add(new MailboxAddress("Адміністрація готелю PREMIER", _settings.MailName));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = message
            };

            using (SmtpClient client = new())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync(_settings.MailName, _settings.MailPassword);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}

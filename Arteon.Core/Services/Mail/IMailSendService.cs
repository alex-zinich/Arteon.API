namespace Arteon.Core.Services.Mail
{
    public interface IMailSendService
    {
        public Task SendEmailAsync(string email, string subject, string message);
    }
}
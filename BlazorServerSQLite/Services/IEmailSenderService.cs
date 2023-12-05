using BlazorServerSQLite.Data;

namespace BlazorServerSQLite.Services
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}

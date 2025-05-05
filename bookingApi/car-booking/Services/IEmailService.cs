using car_booking.Models;
namespace car_booking.Services;
using MimeKit;

public interface IEmailService
{
    public Task SendEmailAsync(string email, string subject, string content);
        
    public Task LogEmail(EmailRequest emailRequest);
        
    public Task SendMessage(MimeMessage message);
}
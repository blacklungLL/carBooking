using car_booking.Models;
using car_booking.Services;
using Microsoft.AspNetCore.Mvc;

namespace car_booking.Controllers;

[ApiController]
[Route("[controller]")]
public class EmailController : ControllerBase
{   
    private readonly IEmailService _emailService;
    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }
    [HttpPost]
    public async Task<IActionResult> SendEmail([FromForm] EmailRequest request)
    {
        var subject = $"Заявка принята, Поздравляю, {request.Name}!";
        var body = "поздравляю вас с передачей всей информации по вашей личности на почту обладателя сайта)))) Лошара АХАХАХХАХАХ";
        _emailService.SendEmailAsync(request.Email, subject, body);
        _emailService.LogEmail(request);
        return Ok();
    }
}
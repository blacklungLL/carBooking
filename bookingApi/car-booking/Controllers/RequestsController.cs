using car_booking.Models;
using Microsoft.AspNetCore.Mvc;

namespace car_booking.Controllers;

public class RequestsController : ControllerBase
{
    [HttpPost]
    public IActionResult SendRequest([FromForm] RequestForm requestForm)
    {
        // TODO: 1 семестр
        return Ok();
    }
    
}
using car_booking.Data;
using car_booking.Models;
using Microsoft.AspNetCore.Mvc;

namespace car_booking.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CommentsController
{
    [HttpGet("Comment/{id:int}")]
    public IEnumerable<Comment> Get(int id)
        => CommentsData.Comments.Where(x => x.CarId == id);
}
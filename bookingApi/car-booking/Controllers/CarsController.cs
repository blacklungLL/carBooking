using car_booking.Models;
using car_booking.Persistence;
using car_booking.Services;
using Microsoft.AspNetCore.Mvc;

namespace car_booking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly CarService _carService;

        public CarsController(ApplicationDbContext context, CarService carService)
        {
            _context = context;
            _carService = carService;
        }
        
        [HttpGet("all")]
        public ActionResult<IEnumerable<CarVm>> GetAll()
            => Ok(_context.Cars.AsEnumerable().Select(x => new CarVm(x)));
        
        [HttpGet("{id}")]
        public ActionResult<CarVm?> GetCarById([FromRoute] int id)
            => Ok(new CarVm(
                _context.Cars.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Car with id {id} not found.")));
        
        [HttpGet("filter")]
        public IActionResult GetFilteredCars(
            [FromQuery] string? name,
            [FromQuery] string? types,      // Категории автомобилей
            [FromQuery] string? capacities, // Вместимость
            [FromQuery] decimal? price)     // Максимальная цена
        {
            try
            {
                var filteredCars = _carService.GetFiltered(name, types, capacities, price);
                return Ok(filteredCars);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
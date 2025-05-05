using car_booking.Models;
using car_booking.Extensions;
using car_booking.Persistence;

namespace car_booking.Services
{
    public class CarService
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CarVm> GetFiltered(
            string? name,
            string? types,
            string? capacities,
            decimal? price)
        {
            var typeList = types?.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .ToList();

            var capacityList = capacities?.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(c => int.Parse(c.Trim()))
                .ToList();

            return _context.Cars
                .WhereIfNotNull(name, x => x.Name.ToLower().Contains(name!.ToLower()))
                .WhereIfNotNull(typeList, x => typeList.Contains(x.Category, StringComparer.OrdinalIgnoreCase))
                .WhereIfNotNull(capacityList, x => capacityList.Contains(x.Spaces))
                .WhereIfNotNull(price, p => p.Price <= price)
                .Select(car => new CarVm(car))
                .ToList();
        }
    }
}
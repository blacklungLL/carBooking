using car_booking.Entities;
using car_booking.Enums;

namespace car_booking.Models;

public class CarVm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Img { get; set; }
    public int Liters { get; set; }
    public string Transmission { get; set; }
    public int Spaces { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    
    public CarVm(Car carVm)
    {
        Id = carVm.Id;
        Name = carVm.Name;
        Category = carVm.Category;
        Img = carVm.Img;
        Liters = carVm.Liters;
        Transmission = carVm.Transmission;
        Spaces = carVm.Spaces;
        Price = carVm.Price;
        Description = carVm.Description;
    }
}
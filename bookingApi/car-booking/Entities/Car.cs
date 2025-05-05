using System.ComponentModel.DataAnnotations;

namespace car_booking.Entities;

public class Car
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Img { get; set; }
    public int Liters { get; set; }
    public string Transmission { get; set; }
    public int Spaces { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}
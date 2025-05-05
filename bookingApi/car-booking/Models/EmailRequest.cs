namespace car_booking.Models ;

public class EmailRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string? Address { get; set; }
    public string? TownCity { get; set; }
    public string? PickupLocation { get; set; }
    public string? PickupDate { get; set; }
    public string? PickupTime { get; set; }
    public string? DropOffLocation { get; set; }
    public string? DropOffDate { get; set; }
    public string? DropOffTime { get; set; }
    public string? CardNumber { get; set; }
    public string? ExpirationDate { get; set; }
    public string? CardHolder { get; set; }
    public string? Cvc { get; set; }
    public string? TermsChecked { get; set; }
    public string? PrivacyChecked { get; set; }
}
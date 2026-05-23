namespace HotelListing.API.Domain;

public class HotelAdmin
{
    public int Id { get; set; }

    public Hotel? Hotel { get; set; }
    public ApplicationUser? User { get; set; }
    public int HotelId { get; set; }
    public string UserId { get; set; } = string.Empty;
}
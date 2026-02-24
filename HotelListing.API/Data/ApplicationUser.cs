using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Data;

public class ApplicationUser: IdentityUser
{
    public string FristName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
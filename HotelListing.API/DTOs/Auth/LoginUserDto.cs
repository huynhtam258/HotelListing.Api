using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Auth;

public class LoginUserDto
{

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}

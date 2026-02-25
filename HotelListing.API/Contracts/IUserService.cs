using HotelListing.API.DTOs.Auth;
using HotelListing.API.Results;

namespace HotelListing.API.Contracts;

public interface IUserService
{
    Task<Result<string>> LoginAsync(LoginUserDto dto);
    Task<Result<RegisteredUserDto>> RegisterAsync(RegisterUserDto registerUserDto);
}
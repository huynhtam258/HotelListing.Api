using HotelListing.API.Common.Results;
using HotelListing.API.Application.DTOs.Auth;

namespace HotelListing.API.Application.Contracts;

public interface IUsersService
{
    string UserId { get; }
    Task<Result<string>> LoginAsync(LoginUserDto dto);
    Task<Result<RegisteredUserDto>> RegisterAsync(RegisterUserDto registerUserDto);
}
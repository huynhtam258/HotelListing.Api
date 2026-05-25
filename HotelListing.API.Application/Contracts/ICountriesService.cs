using HotelListing.API.Common.Results;
using HotelListing.API.Application.DTOs.Country;
using HotelListing.API.Common.Models.Paging;
using HotelListing.API.Application.DTOs.Hotel;

namespace HotelListing.API.Application.Contracts;

public interface ICountriesService
{
    Task<bool> CountryExistsAsync(int id);
    Task<bool> CountryExistsAsync(string name);
    Task<Result<GetCountryDto>> CreateCountryAsync(CreateCountryDto createDto);
    Task<Result> DeleteCountryAsync(int id);
    Task<Result<IEnumerable<GetCountriesDto>>> GetCountriesAsync();
    Task<Result<GetCountryDto>> GetCountryAsync(int id);
    Task<Result> UpdateCountryAsync(int id, UpdateCountryDto updateDto);
    Task<Result<PagedResult<GetHotelDto>>> GetCountryHotelsAsync(int id, PaginationParameters paginationParameters);

}

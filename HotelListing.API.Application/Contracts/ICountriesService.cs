using HotelListing.API.Common.Results;
using HotelListing.API.Application.DTOs.Country;
using HotelListing.API.Common.Models.Paging;
using HotelListing.API.Application.DTOs.Hotel;
using HotelListing.API.Common.Models.Filtering;

namespace HotelListing.API.Application.Contracts;

public interface ICountriesService
{
    Task<bool> CountryExistsAsync(int id);
    Task<bool> CountryExistsAsync(string name);
    Task<Result<GetCountryDto>> CreateCountryAsync(CreateCountryDto createDto);
    Task<Result> DeleteCountryAsync(int id);
    Task<Result<IEnumerable<GetCountriesDto>>> GetCountriesAsync(CountryFilterParameters filters);
    Task<Result<GetCountryDto>> GetCountryAsync(int id);
    Task<Result> UpdateCountryAsync(int id, UpdateCountryDto updateDto);
    Task<Result<GetCountryHotelsDto>> GetCountryHotelsAsync(int id, PaginationParameters paginationParameters, CountryFilterParameters filters);

}

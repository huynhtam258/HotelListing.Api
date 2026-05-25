using HotelListing.Api.Common.Models.Filtering;
using HotelListing.API.Application.DTOs.Hotel;
using HotelListing.API.Common.Models.Paging;
using HotelListing.API.Common.Results;

namespace HotelListing.API.Application.Contracts;

public interface IHotelsService
{
    // Keep these for quick checks elsewhere if needed
    Task<bool> HotelExistsAsync(int id);
    Task<bool> HotelExistsAsync(string name, int countryId);
    Task<Result<PagedResult<GetHotelDto>>> GetHotelsAsync(PaginationParameters paginationParameters, HotelFilterParameters filters);
    Task<Result<GetHotelDto>> GetHotelAsync(int id);
    Task<Result<GetHotelDto>> CreateHotelAsync(CreateHotelDto createDto);
    Task<Result> UpdateHotelAsync(int id, UpdateHotelDto updateDto);
    Task<Result> DeleteHotelAsync(int id);
}
using HotelListing.API.Application.DTOs.Country;
using HotelListing.API.Common.Results;
using HotelListing.API.Application.DTOs.Booking;

namespace HotelListing.API.Application.Contracts;

public interface IBookingService
{
    Task<Result> AdminCancelBookingAsync(int hotelId, int bookingId);
    Task<Result> CancelBookingAsync(int hotelId, int bookingId);
    Task<Result> AdminConfirmBookingAsync(int hotelId, int bookingId);
    Task<Result<GetBookingDto>> CreateBookingAsync(CreateBookingDto dto);
    Task<Result<IEnumerable<GetBookingDto>>> GetBookingsForHotelAsync(int hotelId);
    Task<Result<GetBookingDto>> UpdateBookingAsync(int hotelId, int bookingId, UpdateBookingDto updateBookingDto);
    Task<Result<IEnumerable<GetBookingDto>>> GetUserBookingsForHotelAsync(int hotelId);
}

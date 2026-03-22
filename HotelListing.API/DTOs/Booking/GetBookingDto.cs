namespace HotelListing.API.DTOs.Booking;

public record GetBookingDto(
    int Id,
    int HotelId,
    string HotelName,
    DateOnly CheckIn,
    DateOnly CheckOut,
    int Guests,
    string Status,
    DateTime CreatedAtStatus,
    DateTime? UpdatedAtStatus
);

public record CreateBookingDto
(
    int HotelId,
    DateOnly CheckIn,
    DateOnly CheckOut,
    int Guests
);
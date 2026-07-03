using HotelListing.API.Application.Contracts;
using HotelListing.API.Application.DTOs.Booking;
using HotelListing.API.AuthorizationFilters;
using HotelListing.API.Common.Constants;
using HotelListing.API.Common.Models.Filtering;
using HotelListing.API.Common.Models.Paging;
using HotelListing.API.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

[Route("api/hotels/{hotelId:int}/bookings")]
[ApiController]
[Authorize]
[EnableRateLimiting(RateLimitingConstants.PerUserPolicy)]
public class HotelBookingsController(IBookingService bookingService): BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<PagedResult<GetBookingDto>>> GetBookings([FromRoute] int hotelId, [FromQuery] PaginationParameters paginationParameters, [FromQuery] BookingFilterParameters filters)
    {
        var result = await bookingService.GetBookingsForHotelAsync(hotelId, paginationParameters, filters);
        return ToActionResult(result);
    }

    public async Task<ActionResult<PagedResult<GetBookingDto>>> GetUserBookingsForHotelAsync([FromRoute] int hotelId, [FromQuery] PaginationParameters paginationParameters, [FromQuery] BookingFilterParameters filters)
    {
        var result = await bookingService.GetUserBookingsForHotelAsync(hotelId, paginationParameters, filters);
        return ToActionResult(result);
    }

    [HttpPost]
    public async Task<ActionResult<GetBookingDto>> CreateBooking([FromRoute] int HotelId, [FromBody] CreateBookingDto createBookingDto)
    {
        var result = await bookingService.CreateBookingAsync(createBookingDto);
        return ToActionResult(result);
    }

    [HttpPut("{bookingId:int}")]
    public async Task<ActionResult<GetBookingDto>> UpdateBooking(
        [FromRoute] int hotelId,
        [FromRoute] int bookingId,
        [FromBody] UpdateBookingDto updateBookingDto)
    {
        var result = await bookingService.UpdateBookingAsync(hotelId, bookingId, updateBookingDto);
        return ToActionResult(result);
    }

    [HttpPut("{bookingId:int}/cancel")]
    public async Task<IActionResult> CancelBooking([FromRoute] int hotelId, [FromRoute] int bookingId)
    {
        var result = await bookingService.CancelBookingAsync(hotelId, bookingId);
        return ToActionResult(result);
    }

    [HttpGet("admin")]
    [HotelOrSystemAdmin]
    public async Task<ActionResult<PagedResult<GetBookingDto>>> GetBookingsAdmin([FromRoute] int hotelId, [FromQuery] PaginationParameters paginationParameters, [FromQuery] BookingFilterParameters filters)
    {
        var result = await bookingService.GetBookingsForHotelAsync(hotelId, paginationParameters, filters);
        return ToActionResult(result);
    }

    [HttpPut("{bookingId:int}/admin/cancel")]
    [HotelOrSystemAdmin]
    public async Task<IActionResult> AdminCancelBooking([FromRoute] int hotelId, [FromRoute] int bookingId)
    {
        var result = await bookingService.AdminCancelBookingAsync(hotelId, bookingId);
        return ToActionResult(result);
    }

    [HttpPut("{bookingId:int}/admin/confirm")]
    [HotelOrSystemAdmin]
    public async Task<IActionResult> AdminConfirmBooking([FromRoute] int hotelId, [FromRoute] int bookingId)
    {
        var result = await bookingService.AdminConfirmBookingAsync(hotelId, bookingId);
        return ToActionResult(result);
    }

}
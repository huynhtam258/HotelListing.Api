using HotelListing.Api.Common.Models.Filtering;
using HotelListing.API.Application.Contracts;
using HotelListing.API.Application.DTOs.Hotel;
using HotelListing.API.Common.Models.Paging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class HotelsController(IHotelsService hotelsService) : BaseApiController
{
    // GET: api/Hotels
    [HttpGet]
    public async Task<ActionResult<PagedResult<GetHotelDto>>> GetHotels(
        [FromQuery] PaginationParameters paginationParameters, 
        [FromQuery] HotelFilterParameters filters)
    {
        var result = await hotelsService.GetHotelsAsync(paginationParameters, filters);
        return ToActionResult(result);
    }

    // GET: api/Hotels/5
    [HttpGet("{id}")]
    public async Task<ActionResult<GetHotelDto>> GetHotel(int id)
    {
        var result = await hotelsService.GetHotelAsync(id);
        return ToActionResult(result);
    }

    // PUT: api/Hotels/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutHotel(int id, UpdateHotelDto hotelDto)
    {
        if (id != hotelDto.Id)
        {
            return BadRequest("Id route value must match payload Id.");
        }

        var result = await hotelsService.UpdateHotelAsync(id, hotelDto);
        return ToActionResult(result);
    }

    // POST: api/Hotels
    [HttpPost]
    public async Task<ActionResult<GetHotelDto>> PostHotel(CreateHotelDto hotelDto)
    {
        var result = await hotelsService.CreateHotelAsync(hotelDto);
        if (!result.IsSuccess) return MapErrorsToResponse(result.Errors);

        return CreatedAtAction(nameof(GetHotel), new { id = result.Value!.Id }, result.Value);
    }

    // DELETE: api/Hotels/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHotel(int id)
    {
        var result = await hotelsService.DeleteHotelAsync(id);
        return ToActionResult(result);
    }
}
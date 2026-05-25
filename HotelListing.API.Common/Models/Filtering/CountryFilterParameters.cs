using HotelListing.API.Common.Models.Filtering;

namespace HotelListing.API.Common.Models.Filtering;

public class CountryFilterParameters : BaseFilterParameters
{
    public string? CountryName { get; set; }
    public bool? HasHotels { get; set; }
}
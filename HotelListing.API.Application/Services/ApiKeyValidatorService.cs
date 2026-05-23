using HotelListing.API.Application.Contracts;
using Microsoft.Extensions.Configuration;

namespace HotelListing.API.Application.Services;

public class ApiKeyValidatorService(IConfiguration configuration): IApiKeyValidatorService
{
    public Task<bool> IsValidAsync(string apiKey, CancellationToken cl = default)
    {
        return Task.FromResult(apiKey.Equals(configuration["ApiKey"]));
    }
}

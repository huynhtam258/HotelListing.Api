using HotelListing.API.Contracts;

namespace HotelListing.API.Services;

public class ApiKeyValidatorService(IConfiguration configuration): IApiKeyValidatorService
{
    public Task<bool> IsValidAsync(string apiKey, CancellationToken cl = default)
    {
        return Task.FromResult(apiKey.Equals(configuration["ApiKey"]));
    }
}

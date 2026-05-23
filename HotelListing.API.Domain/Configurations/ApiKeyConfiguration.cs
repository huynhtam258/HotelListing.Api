using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Domain.Configurations;

public class ApiKeyConfiguration : IEntityTypeConfiguration<ApiKey>
{
    public void Configure(EntityTypeBuilder<ApiKey> builder)
    {
        builder.Property(k => k.Id).ValueGeneratedOnAdd();
        builder.Property(k => k.CreatedAtUtc).HasDefaultValueSql("SYSUTCDATETIME()");
        builder.HasIndex(k => k.Key).IsUnique();
        builder.HasData(
            new ApiKey
            {
                Id = 1,
                AppName = "app",
                CreatedAtUtc = new DateTime(2025, 01, 01),
                Key = "dXNlcjFAbG9jYWxob3N0LmNvbTpQQHNzd29yZDE="

            }
        );
    }
}

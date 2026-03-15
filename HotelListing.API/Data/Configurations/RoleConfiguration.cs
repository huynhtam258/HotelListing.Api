using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations;

public class RoleConfiguration: IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {

        builder.HasData(
            new IdentityRole
            {
                Id = "c78e8f15-6a6c-4c8a-b5d1-98394b071953",
                ConcurrencyStamp = "7ef0d286-4d66-41dc-b95f-34a24f2fb1fd",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "36aac992-72ff-4527-9008-52e7c145ca39",
                ConcurrencyStamp = "25f9aa0e-9f1f-4dd4-af24-62cc84f2ecba",
                Name = "User",
                NormalizedName = "USER"
            }
        );
    }
}

using HotelListing.API.Common.Constants;            
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Domain.Configurations;

public class RoleConfiguration: IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {

        builder.HasData(
            new IdentityRole
            {
                Id = "c78e8f15-6a6c-4c8a-b5d1-98394b071953",
                ConcurrencyStamp = "7ef0d286-4d66-41dc-b95f-34a24f2fb1fd",
                Name = RoleNames.Administrator,
                NormalizedName = RoleNames.Administrator.ToUpper()
            },
            new IdentityRole
            {
                Id = "36aac992-72ff-4527-9008-52e7c145ca39",
                ConcurrencyStamp = "25f9aa0e-9f1f-4dd4-af24-62cc84f2ecba",
                Name = RoleNames.User,
                NormalizedName = RoleNames.User.ToUpper()
            },
            new IdentityRole
            {
                Id = "36aac992-4c8a-4527-9008-98394b071953",
                ConcurrencyStamp = "f26d55af-fe2b-43e3-b646-c6e1689efe0d",
                Name = RoleNames.HotelAdmin,
                NormalizedName = RoleNames.HotelAdmin.ToUpper()
            }
        );
    }
}

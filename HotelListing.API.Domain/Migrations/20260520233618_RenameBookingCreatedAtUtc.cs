using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class RenameBookingCreatedAtUtc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAtUTC",
                table: "Bookings",
                newName: "UpdatedAtUtc");

            migrationBuilder.RenameColumn(
                name: "CreateAtUTC",
                table: "Bookings",
                newName: "CreatedAtUtc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAtUtc",
                table: "Bookings",
                newName: "UpdatedAtUTC");

            migrationBuilder.RenameColumn(
                name: "CreatedAtUtc",
                table: "Bookings",
                newName: "CreateAtUTC");
        }
    }
}

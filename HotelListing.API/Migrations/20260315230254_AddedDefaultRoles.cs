using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36aac992-72ff-4527-9008-52e7c145ca39", "4d0f005a-f254-47c3-b7ce-05e9ec01f8ae", "User", "USER" },
                    { "c78e8f15-6a6c-4c8a-b5d1-98394b071953", "14a3d04b-c92e-493c-bed9-dcd045c3a639", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36aac992-72ff-4527-9008-52e7c145ca39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78e8f15-6a6c-4c8a-b5d1-98394b071953");
        }
    }
}

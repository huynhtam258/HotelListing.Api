using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class FixRoleSeedConcurrencyStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36aac992-72ff-4527-9008-52e7c145ca39",
                column: "ConcurrencyStamp",
                value: "25f9aa0e-9f1f-4dd4-af24-62cc84f2ecba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78e8f15-6a6c-4c8a-b5d1-98394b071953",
                column: "ConcurrencyStamp",
                value: "7ef0d286-4d66-41dc-b95f-34a24f2fb1fd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36aac992-72ff-4527-9008-52e7c145ca39",
                column: "ConcurrencyStamp",
                value: "4d0f005a-f254-47c3-b7ce-05e9ec01f8ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78e8f15-6a6c-4c8a-b5d1-98394b071953",
                column: "ConcurrencyStamp",
                value: "14a3d04b-c92e-493c-bed9-dcd045c3a639");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class RenameFristNameToFirstName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                IF COL_LENGTH('AspNetUsers', 'FristName') IS NOT NULL
                   AND COL_LENGTH('AspNetUsers', 'FirstName') IS NULL
                BEGIN
                    EXEC sp_rename N'[AspNetUsers].[FristName]', N'FirstName', 'COLUMN';
                END
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                """
                IF COL_LENGTH('AspNetUsers', 'FirstName') IS NOT NULL
                   AND COL_LENGTH('AspNetUsers', 'FristName') IS NULL
                BEGIN
                    EXEC sp_rename N'[AspNetUsers].[FirstName]', N'FristName', 'COLUMN';
                END
                """);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApiKeyIdAndDefaults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiKeys_New",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    AppName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ExpiresAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValueSql: "SYSUTCDATETIME()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiKeys_New", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiKeys_New_Key",
                table: "ApiKeys_New",
                column: "Key",
                unique: true);

            migrationBuilder.Sql(
                """
                SET IDENTITY_INSERT [ApiKeys_New] ON;
                INSERT INTO [ApiKeys_New] ([Id], [Key], [AppName], [ExpiresAtUtc], [CreatedAtUtc])
                VALUES (1, N'dXNlcjFAbG9jYWxob3N0LmNvbTpQQHNzd29yZDE=', N'app', NULL, '2025-01-01T00:00:00+07:00');
                SET IDENTITY_INSERT [ApiKeys_New] OFF;
                """);

            migrationBuilder.Sql(
                """
                INSERT INTO [ApiKeys_New] ([Key], [AppName], [ExpiresAtUtc], [CreatedAtUtc])
                SELECT [Key], [AppName], [ExpiresAtUtc], [CreatedAtUtc]
                FROM [ApiKeys]
                WHERE NOT EXISTS (
                    SELECT 1
                    FROM [ApiKeys_New]
                    WHERE [ApiKeys_New].[Key] = [ApiKeys].[Key]
                );
                """);

            migrationBuilder.DropTable(
                name: "ApiKeys");

            migrationBuilder.RenameTable(
                name: "ApiKeys_New",
                newName: "ApiKeys");

            migrationBuilder.RenameIndex(
                name: "IX_ApiKeys_New_Key",
                table: "ApiKeys",
                newName: "IX_ApiKeys_Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiKeys_Old",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    AppName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ExpiresAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAtUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiKeys_Old", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiKeys_Old_Key",
                table: "ApiKeys_Old",
                column: "Key",
                unique: true);

            migrationBuilder.Sql(
                """
                INSERT INTO [ApiKeys_Old] ([Id], [Key], [AppName], [ExpiresAtUtc], [CreatedAtUtc])
                SELECT CONVERT(nvarchar(450), [Id]), [Key], [AppName], [ExpiresAtUtc], [CreatedAtUtc]
                FROM [ApiKeys];
                """);

            migrationBuilder.DropTable(
                name: "ApiKeys");

            migrationBuilder.RenameTable(
                name: "ApiKeys_Old",
                newName: "ApiKeys");

            migrationBuilder.RenameIndex(
                name: "IX_ApiKeys_Old_Key",
                table: "ApiKeys",
                newName: "IX_ApiKeys_Key");
        }
    }
}

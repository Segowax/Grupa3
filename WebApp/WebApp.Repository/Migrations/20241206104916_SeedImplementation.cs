using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedImplementation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 6, 10, 49, 15, 942, DateTimeKind.Utc).AddTicks(495), "test@gadshgdsagd.com", "test", "test", 1 },
                    { 2, new DateTime(2024, 12, 6, 10, 49, 15, 942, DateTimeKind.Utc).AddTicks(518), "test@gadshgdsagd.com", "test", "test", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

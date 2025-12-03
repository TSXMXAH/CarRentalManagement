using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(3567), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(3589), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(3595), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(3597), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4022), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4023), "BMW", "System" },
                    { 4, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4028), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4030), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 5, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4177), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4179), "i4", "System" },
                    { 6, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4183), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4184), "X5", "System" },
                    { 7, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4188), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4189), "Prius", "System" },
                    { 8, "System", new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4192), new DateTime(2025, 12, 3, 14, 50, 27, 972, DateTimeKind.Local).AddTicks(4194), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}

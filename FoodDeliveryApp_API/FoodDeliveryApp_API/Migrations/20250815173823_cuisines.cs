using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDeliveryApp_API.Migrations
{
    /// <inheritdoc />
    public partial class cuisines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cuisines",
                columns: new[] { "CuisineId", "CuisineType" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 9 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 9 },
                    { 11, 10 },
                    { 12, 11 },
                    { 13, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "CuisineId",
                keyValue: 13);
        }
    }
}

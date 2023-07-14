using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _4migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Basket");

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "одежда" },
                    { 2, "автомобили" },
                    { 3, "товары для животных" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Balance", "BasketId", "Password", "Purchase", "Role", "UserName" },
                values: new object[] { 1, 0m, 0, "123456", 0m, 2, "Mike" });

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Basket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineMarket.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "BasketId", "UserId" },
                values: new object[] { 5, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "BasketId",
                keyValue: 5);
        }
    }
}

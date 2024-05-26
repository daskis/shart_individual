using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zhuravlev_34.Migrations
{
    /// <inheritdoc />
    public partial class addRemainingAmountToSell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RemainingAmount",
                table: "SellOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemainingAmount",
                table: "SellOrders");
        }
    }
}

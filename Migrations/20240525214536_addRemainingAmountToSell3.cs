using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zhuravlev_34.Migrations
{
    /// <inheritdoc />
    public partial class addRemainingAmountToSell3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SellOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "SellOrders");
        }
    }
}

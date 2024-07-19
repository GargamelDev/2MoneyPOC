using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2MoneyPOC.Migrations
{
    /// <inheritdoc />
    public partial class Account_AmmountAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Ammount",
                table: "Accounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ammount",
                table: "Accounts");
        }
    }
}

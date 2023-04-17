using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dalmARTSY_Test.Migrations
{
    public partial class CreateModelTablesUpdatedVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "Orders",
                type: "decimal(9,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "Orders");
        }
    }
}

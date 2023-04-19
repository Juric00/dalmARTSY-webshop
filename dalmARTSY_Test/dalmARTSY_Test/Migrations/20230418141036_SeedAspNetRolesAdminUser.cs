using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dalmARTSY_Test.Migrations
{
    public partial class SeedAspNetRolesAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "Administrator-000", "48b96d8e-0d6c-47fb-80c2-dcef099941d7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "User-000", "dbcafe9e-4a70-4a4d-b8db-cee36cd1f19f", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Administrator-000");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User-000");
        }
    }
}

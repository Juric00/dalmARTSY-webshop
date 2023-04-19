using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dalmARTSY_Test.Migrations
{
    public partial class AspNetUserRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Administrator-000",
                column: "ConcurrencyStamp",
                value: "1e6c98f4-feca-4f38-9977-12a4b946e143");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User-000",
                column: "ConcurrencyStamp",
                value: "7df66c85-2c03-4784-b470-7fb301d6477e");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "Administrator-000", "A100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "331b6ece-9b5c-480e-a456-245aba68784e", "AQAAAAEAACcQAAAAEDq7pGH7eom5/iqCygd+0TCtelpFPRZPppZengTNDPHiIovaEFLhXZcXZL0KbkL+gA==", "74a700a1-47c9-4883-9289-bbce119bc438" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "Administrator-000", "A100" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Administrator-000",
                column: "ConcurrencyStamp",
                value: "f59dd988-0a0f-4fb0-865a-6ae061b16041");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "User-000",
                column: "ConcurrencyStamp",
                value: "ab80b477-89a4-403c-b338-e716c4589db6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17e712e1-d65d-4609-b778-f623131181be", "AQAAAAEAACcQAAAAEKAg4J2PoekdLfSZvkUzLCc5ai2RbqqMTJQ2WQtQCjhRJb7s9weBvH+LPnCsGCPT8w==", "77de72aa-9f7f-434b-a292-261592a91b14" });
        }
    }
}

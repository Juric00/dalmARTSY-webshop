using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dalmARTSY_Test.Migrations
{
    public partial class dalmARTimageRequiredRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ce0f798-67a5-4957-adae-c1e2bb402f74",
                column: "ConcurrencyStamp",
                value: "bfb66017-5467-4672-824c-8eaa37097366");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb27c1d-d9de-4ae7-8206-fec010a5004b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6d607d0-8835-4330-8686-bd0a510d205f", "AQAAAAEAACcQAAAAEP77bc/S25n/Drag2cLAC7i5wggEwfIG/bcVS1ZRqGedyPQLfyW05c8S2TrD2nNGsg==", "811e5ef2-a174-4d6a-819e-9cc910f0fcb8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ce0f798-67a5-4957-adae-c1e2bb402f74",
                column: "ConcurrencyStamp",
                value: "01ac5296-fb64-4ecd-8786-c7326cd5fa56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb27c1d-d9de-4ae7-8206-fec010a5004b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1d71766-e8a0-4b03-a409-e12914db3597", "AQAAAAEAACcQAAAAEEG2njC2mm+aXQstYT42c4/d41kC1IwGP32deW9IqhTOiGSgadkZXj/v5YNeHeTFmQ==", "d1574435-1461-484e-9a34-769b849ae46c" });
        }
    }
}

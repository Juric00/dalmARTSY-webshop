using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dalmARTSY_Test.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ce0f798-67a5-4957-adae-c1e2bb402f74",
                column: "ConcurrencyStamp",
                value: "217e9008-5ee8-4be7-b6fc-4d30b1d45b69");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb27c1d-d9de-4ae7-8206-fec010a5004b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f7cf42a-b44b-494b-8e58-058c3a3e9766", "AQAAAAEAACcQAAAAEAlXWxjKTM/qFPzCXp0/cn0SFXcwzR/b8dsmn9H0urrFJW7IB867wyX+ZFBR8tZJOQ==", "788a8c53-093f-45f5-9cf4-d109a52f6d28" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtCode", "Author", "CategoryId", "Description", "Frame", "Height", "Image", "InStock", "Price", "Title", "Width" },
                values: new object[,]
                {
                    { 7, "PA103", "Lukrecija Juric", 1, "Description ...update needed", true, 100m, null, 2, 50.9m, "She with hers", 40m },
                    { 8, "PA104", "Lukrecija Juric", 1, "Description ...update needed", true, 50m, null, 2, 89.00m, "Nature as it is", 100m },
                    { 9, "PA105", "Lukrecija Juric", 1, "Description ...update needed", true, 40m, null, 1, 75.00m, "Somehow", 60m },
                    { 10, "D101", "Lukrecija Juric", 4, "Description ...update needed", true, 60m, null, 5, 79.00m, "Artsy", 80m },
                    { 11, "PA106", "Lukrecija Juric", 1, "Description ...update needed", true, 100m, null, 1, 90.99m, "Antidote", 140m },
                    { 12, "D102", "Lukrecija Juric", 4, "Description ...update needed", false, 20m, null, 3, 70.00m, "Objects", 40m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

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
    }
}

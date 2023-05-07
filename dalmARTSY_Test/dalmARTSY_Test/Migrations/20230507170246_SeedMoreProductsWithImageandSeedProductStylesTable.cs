using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dalmARTSY_Test.Migrations
{
    public partial class SeedMoreProductsWithImageandSeedProductStylesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ce0f798-67a5-4957-adae-c1e2bb402f74",
                column: "ConcurrencyStamp",
                value: "c8c0b890-8fb2-4beb-b7d7-b81335c59256");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb27c1d-d9de-4ae7-8206-fec010a5004b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a61c454-c10e-4664-8f84-951de87d5149", "AQAAAAEAACcQAAAAEOpzo0I8rpqtUC/CmmOVZJY891rliM0DdCGZkWg9pPZCHIwexcfm3v/zz/Z+EzK90g==", "0981ae09-5dee-48b8-bc06-2ca08af38a31" });

            migrationBuilder.InsertData(
                table: "ProductStyles",
                columns: new[] { "Id", "ProductId", "StyleId" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 2, 5 },
                    { 3, 3, 5 },
                    { 4, 4, 1 },
                    { 5, 5, 2 },
                    { 6, 5, 3 },
                    { 7, 6, 3 },
                    { 8, 7, 3 },
                    { 9, 7, 5 },
                    { 10, 8, 3 },
                    { 11, 8, 5 },
                    { 12, 9, 5 },
                    { 13, 10, 3 },
                    { 14, 10, 2 },
                    { 15, 11, 5 },
                    { 16, 12, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Title", "Width" },
                values: new object[] { "the_angel.jpeg", "The One with Angel", 80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Frame", "Height", "Image", "Width" },
                values: new object[] { false, 120m, "shining_one.jpeg", 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArtCode", "Author", "CategoryId", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA102", "Lukrecija Juric", 1, 50m, "the_olive.jpeg", "The Olives", 60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArtCode", "Author", "CategoryId", "Image", "Title", "Width" },
                values: new object[] { "PA103", "Lukrecija Juric", 1, "bubble.jpeg", "The Bubble", 65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArtCode", "Author", "CategoryId", "Frame", "Height", "Image", "Price", "Title", "Width" },
                values: new object[] { "PA104", "Lukrecija Juric", 1, true, 120m, "the_silly_one.jpeg", 120.99m, "The Silly PopArt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArtCode", "Author", "Frame", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA105", "Lukrecija Juric", false, 120m, "the_two.jpeg", "The One with Two", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArtCode", "Height", "Image", "Price", "Title" },
                values: new object[] { "PA106", 70m, "the_afternoon.jpeg", 100m, "The Afternoon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArtCode", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA107", 120m, "dots.jpeg", "The Dots", 70m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArtCode", "Frame", "Image", "Title" },
                values: new object[] { "PA108", false, "summer.jpeg", "Summers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArtCode", "CategoryId", "Frame", "Image", "Title" },
                values: new object[] { "PA109", 1, false, "heart.jpeg", "Heartsy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArtCode", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA110", 50m, "dalsea.jpeg", "Dalsea and beach", 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArtCode", "CategoryId", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA111", 1, 120m, "casual.jpeg", "Casual Pop", 70m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtCode", "Author", "CategoryId", "Description", "Frame", "Height", "Image", "InStock", "Price", "Title", "Width" },
                values: new object[,]
                {
                    { 13, "PA112", "Lukrecija Juric", 1, "Description ...update needed", false, 120m, "darkfall.jpeg", 3, 70.00m, "Dark Fall", 30m },
                    { 14, "PA113", "Lukrecija Juric", 1, "Description ...update needed", false, 40m, "wings.jpeg", 3, 70.00m, "Wingsy", 70m },
                    { 15, "PA114", "Lukrecija Juric", 1, "Description ...update needed", false, 20m, null, 3, 70.00m, "Objects", 40m },
                    { 16, "PA115", "Lukrecija Juric", 1, "Description ...update needed", false, 20m, "lovefall.jpeg", 3, 70.00m, "Fall-in in Love", 40m },
                    { 17, "PH100", "Rhamely Wyunko", 2, "Description ... update needed ", false, 50m, "books.jpeg", 2, 80.99m, "The One with Books", 60m },
                    { 18, "PH101", "Dimitro Franz", 2, "Description ...update needed", true, 80m, "house.jpeg", 1, 120.50m, "The One with House", 80m },
                    { 19, "PH102", "Daniel Torbekov", 2, "Description ...update needed", false, 100m, "deep.jpeg", 1, 50.99m, "Deep Dive", 120m },
                    { 20, "PH103", "Chris Cermak", 2, "Description ...update needed", true, 40m, "mountain.jpeg", 5, 160.00m, "The Mountain", 40m },
                    { 21, "PH104", "Quang Ngueyn", 2, "Description ...", false, 30m, "stones.jpeg", 7, 24.99m, "The Stones", 20m },
                    { 22, "DA100", "Rotislav Uzunov", 3, "Description ...update needed", true, 100m, "square.jpeg", 3, 70.00m, "The Square", 140m },
                    { 23, "DA101", "Mo Eid", 3, "Description ...update needed", true, 100m, "tree.jpeg", 2, 50.9m, "The Tree", 40m },
                    { 24, "DA102", "Rodion Kutsayev", 3, "Description ...update needed", true, 50m, "doors.jpeg", 2, 89.00m, "The Doors", 100m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtCode", "Author", "CategoryId", "Description", "Frame", "Height", "Image", "InStock", "Price", "Title", "Width" },
                values: new object[,]
                {
                    { 25, "DR100", "Tayla Walls", 4, "Description ...update needed", true, 40m, "eye.jpeg", 1, 75.00m, "The Eye", 60m },
                    { 26, "DR101", "David Guerrero", 4, "Description ...update needed", true, 60m, "face.jpeg", 5, 79.00m, "The Face", 80m },
                    { 27, "MM100", "Steve Johnson", 5, "Description ...update needed", true, 100m, "mixy.jpeg", 1, 90.99m, "The Mixy", 140m },
                    { 28, "MM101", "Velroy Fernandes", 5, "Description ...update needed", false, 20m, "divinginto", 3, 70.00m, "Diving Into", 40m },
                    { 29, "MM102", "Steve Johnson", 5, "Description ...update needed", false, 20m, "reddot", 3, 70.00m, "The red Dot", 40m },
                    { 30, "MM103", "Zakuskek Ayar", 5, "Description ...update needed", false, 20m, "zeta", 3, 70.00m, "Zeta Blue", 40m }
                });

            migrationBuilder.InsertData(
                table: "ProductStyles",
                columns: new[] { "Id", "ProductId", "StyleId" },
                values: new object[,]
                {
                    { 17, 13, 5 },
                    { 18, 13, 1 },
                    { 19, 14, 5 },
                    { 20, 14, 1 },
                    { 21, 15, 1 },
                    { 22, 16, 5 },
                    { 23, 16, 2 },
                    { 24, 17, 5 },
                    { 25, 18, 5 },
                    { 26, 19, 1 },
                    { 27, 19, 2 },
                    { 28, 20, 5 },
                    { 29, 21, 5 },
                    { 30, 22, 5 },
                    { 31, 22, 1 },
                    { 32, 23, 5 },
                    { 33, 24, 1 },
                    { 34, 24, 5 },
                    { 35, 25, 1 },
                    { 36, 25, 2 },
                    { 37, 26, 1 },
                    { 38, 26, 5 },
                    { 39, 27, 4 },
                    { 40, 27, 1 },
                    { 41, 27, 2 },
                    { 42, 28, 1 },
                    { 43, 28, 5 },
                    { 44, 29, 1 },
                    { 45, 29, 2 },
                    { 46, 30, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductStyles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Title", "Width" },
                values: new object[] { "the_one_with_blue_angel.jpg", "The One with Blue Angel", 60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Frame", "Height", "Image", "Width" },
                values: new object[] { true, 80m, "the_one_that_shines.jpg", 80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArtCode", "Author", "CategoryId", "Height", "Image", "Title", "Width" },
                values: new object[] { "D100", "Irena Martinic", 4, 100m, "sunset_in_vala.jpg", "Sunset in Vala", 120m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArtCode", "Author", "CategoryId", "Image", "Title", "Width" },
                values: new object[] { "MM100", "Keti Zuvic", 5, "portrait_of_a_woman.jpg", "Portrait of a woman", 40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArtCode", "Author", "CategoryId", "Frame", "Height", "Image", "Price", "Title", "Width" },
                values: new object[] { "PH100", "Pero Dragicevic", 2, false, 30m, "our_people.jpg", 24.99m, "Our People", 20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArtCode", "Author", "Frame", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA102", "Branka Kusanovic", true, 100m, "just_an_object.jpg", "Just an Object", 140m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArtCode", "Height", "Image", "Price", "Title" },
                values: new object[] { "PA103", 100m, null, 50.9m, "She with hers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArtCode", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA104", 50m, null, "Nature as it is", 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArtCode", "Frame", "Image", "Title" },
                values: new object[] { "PA105", true, null, "Somehow" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArtCode", "CategoryId", "Frame", "Image", "Title" },
                values: new object[] { "D101", 4, true, null, "Artsy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArtCode", "Height", "Image", "Title", "Width" },
                values: new object[] { "PA106", 100m, null, "Antidote", 140m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArtCode", "CategoryId", "Height", "Image", "Title", "Width" },
                values: new object[] { "D102", 4, 20m, null, "Objects", 40m });
        }
    }
}

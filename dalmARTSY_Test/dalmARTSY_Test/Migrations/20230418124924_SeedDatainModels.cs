using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dalmARTSY_Test.Migrations
{
    public partial class SeedDatainModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "dalmARTSY's paintings are snapshot of an artist's imagination, captured in a moment of time and made tangible through the artist's medium and techniques. ", "painting_category.jpg", "Painting" },
                    { 2, "dalmARTSY's photographers shows the world through the lenses of camera. ", "photography_category.jpg", "Photography" },
                    { 3, "dalmaRTSY's digital art is a fusion of technology and creativity, where artist's medium is pixel.", "digital_art_category.jpg", "Digital Art" },
                    { 4, "dalmaARTSY's drawing represents raw emotions and ideas often created with emphasis on the lines and shapes using pencil with linear quality. ", "drawing_category.jpg", "Drawing" },
                    { 5, "dalmARTSY's mixed media is a combination of traditional and non-traditional art materials and techniques where artist use their imagination to combine different textures, colors and shapes to make one-of-a-kind art that defies categorization", "mixed_media_category.jpg", "Mixed Media" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "Id", "About", "Title" },
                values: new object[,]
                {
                    { 1, "It emphasized the exploration of color, form, and composition, often challenging traditional notions of beauty and realism.", "Modern" },
                    { 2, "Abstract art is characterized by the use of shapes, colors, and forms that are not intended to represent any specific object or recognizable image.", "Abstract" },
                    { 3, "A style that emerged in the 1950s and 60s, characterized by the use of popular culture imagery and objects, such as advertisements, comic books, and everyday consumer products. It often employs bright colors, bold lines, and a sense of humor or irony to critique and comment on contemporary society and mass media.", "Pop Art" },
                    { 4, "Inspired by architecture.Buildings and urban spaces offer a range of textures, forms, and colors, which artists can use to create dynamic and expressive compositions that capture the character and atmosphere of a particular place. ", "Architecture" },
                    { 5, "Refers to a broad range of styles that prioritize the emotional and psychological content of the artwork over realistic representation. It often features exaggerated forms, vibrant colors, and bold brushwork to create a powerful visual impact and convey intense emotions or subjective experiences", "Expressionist" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ArtCode", "Author", "CategoryId", "Description", "Frame", "Height", "Image", "InStock", "Price", "Title", "Width" },
                values: new object[,]
                {
                    { 1, "PA100", "Lukrecija Juric", 1, "Description ... update needed ", false, 50m, "the_one_with_blue_angel.jpg", 2, 80.99m, "The One with Blue Angel", 60m },
                    { 2, "PA101", "Lukrecija Juric", 1, "Description ...update needed", true, 80m, "the_one_that_shines.jpg", 1, 120.50m, "The One that Shines", 80m },
                    { 3, "D100", "Irena Martinic", 4, "Description ...update needed", false, 100m, "sunset_in_vala.jpg", 1, 50.99m, "Sunset in Vala", 120m },
                    { 4, "MM100", "Keti Zuvic", 5, "Description ...update needed", true, 40m, "portrait_of_a_woman.jpg", 5, 160.00m, "Portrait of a woman", 40m },
                    { 5, "PH100", "Pero Dragicevic", 2, "Description ...", false, 30m, "our_people.jpg", 7, 24.99m, "Our People", 20m },
                    { 6, "PA102", "Branka Kusanovic", 1, "Description ...update needed", true, 100m, "just_an_object.jpg", 3, 70.00m, "Just an Object", 140m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

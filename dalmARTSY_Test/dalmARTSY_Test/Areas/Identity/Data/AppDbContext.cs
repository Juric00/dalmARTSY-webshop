using dalmARTSY_Test.Areas.Identity.Data;
using dalmARTSY_Test.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dalmARTSY_Test.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public DbSet <Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Style> Styles { get; set; }
    public DbSet<ProductStyle> ProductStyles { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }



    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        // Seeding Categories
        #region Seeding Categories
        List<Category> artCategories = new List<Category>()
        {
            new Category() { Id = 1, Title = "Painting", Description = "dalmARTSY's paintings are snapshot of an artist's imagination, captured in a moment of time and made tangible through the artist's medium and techniques. ", Image = "painting_category.jpg" },
            new Category() { Id = 2, Title = "Photography", Description = "dalmARTSY's photographers shows the world through the lenses of camera. ", Image = "photography_category.jpg" },
            new Category() { Id = 3, Title = "Digital Art", Description = "dalmaRTSY's digital art is a fusion of technology and creativity, where artist's medium is pixel.", Image = "digital_art_category.jpg"},
            new Category() { Id = 4, Title = "Drawing", Description = "dalmaARTSY's drawing represents raw emotions and ideas often created with emphasis on the lines and shapes using pencil with linear quality. ", Image = "drawing_category.jpg"  },
            new Category() { Id = 5, Title = "Mixed Media", Description = "dalmARTSY's mixed media is a combination of traditional and non-traditional art materials and techniques where artist use their imagination to combine different textures, colors and shapes to make one-of-a-kind art that defies categorization" , Image = "mixed_media_category.jpg"},
        };

        builder.Entity<Category>().HasData(artCategories);

        #endregion

        // Seeding Products
        #region Seeding Products
        List<Product> artProducts = new List<Product>()
        {
            new Product() { Id = 1, CategoryId = 1, Author = "Lukrecija Juric", Title = "The One with Blue Angel", Height = 50, Width = 60, Description = "Description ... update needed ", Frame = false, InStock = 2, Price = 80.99M, ArtCode = "PA100", Image = "the_one_with_blue_angel.jpg" },
            new Product() { Id = 2, CategoryId = 1, Author = "Lukrecija Juric", Title = "The One that Shines", Height = 80, Width = 80, Description = "Description ...update needed", Frame = true, InStock = 1, Price = 120.50M, ArtCode = "PA101", Image = "the_one_that_shines.jpg" },
            new Product() { Id = 3, CategoryId = 4, Author = "Irena Martinic", Title = "Sunset in Vala", Height = 100, Width = 120, Description = "Description ...update needed", Frame = false, InStock = 1, Price = 50.99M, ArtCode = "D100", Image = "sunset_in_vala.jpg"},
            new Product() { Id = 4, CategoryId = 5, Author = "Keti Zuvic", Title = "Portrait of a woman", Height = 40, Width = 40, Description = "Description ...update needed", Frame = true, InStock = 5, Price = 160.00M, ArtCode = "MM100", Image = "portrait_of_a_woman.jpg"},
            new Product() { Id = 5, CategoryId = 2, Author = "Pero Dragicevic", Title = "Our People", Height = 30, Width = 20, Description = "Description ...", Frame = false, InStock = 7, Price = 24.99M, ArtCode = "PH100", Image = "our_people.jpg"},
            new Product() { Id = 6, CategoryId = 1, Author = "Branka Kusanovic", Title = "Just an Object", Height = 100, Width = 140, Description = "Description ...update needed", Frame = true, InStock = 3, Price = 70.00M, ArtCode = "PA102", Image = "just_an_object.jpg"}
        };

        builder.Entity<Product>().HasData(artProducts);
        #endregion

        // Seeding Styles
        #region Seeding Styles
        List<Style> artStyles = new List<Style>()
        {
            new Style() { Id = 1, Title = "Modern", About = "It emphasized the exploration of color, form, and composition, often challenging traditional notions of beauty and realism."},
            new Style() { Id = 2, Title = "Abstract", About = "Abstract art is characterized by the use of shapes, colors, and forms that are not intended to represent any specific object or recognizable image."},
            new Style() { Id = 3, Title = "Pop Art", About = "A style that emerged in the 1950s and 60s, characterized by the use of popular culture imagery and objects, such as advertisements, comic books, and everyday consumer products. It often employs bright colors, bold lines, and a sense of humor or irony to critique and comment on contemporary society and mass media."},
            new Style() { Id = 4, Title = "Architecture", About = "Inspired by architecture.Buildings and urban spaces offer a range of textures, forms, and colors, which artists can use to create dynamic and expressive compositions that capture the character and atmosphere of a particular place. "},
            new Style() { Id = 5, Title = "Expressionist", About = "Refers to a broad range of styles that prioritize the emotional and psychological content of the artwork over realistic representation. It often features exaggerated forms, vibrant colors, and bold brushwork to create a powerful visual impact and convey intense emotions or subjective experiences"}
        };

        builder.Entity<Style>().HasData(artStyles);
        #endregion



        // Seeding Roles
        #region Seeding Roles
        List<IdentityRole> identityRoles = new List<IdentityRole>()
        {
            new IdentityRole() { Id = "9ce0f798-67a5-4957-adae-c1e2bb402f74" , Name = "dalmARTmin", NormalizedName = "dalmARTmin".ToUpper() },
        };

        builder.Entity<IdentityRole>().HasData(identityRoles);
        #endregion

        // Seeding AspNetUsers
        #region Seeding AspNetUsers
        List<AppUser> appUsers = new List<AppUser>()

        {
            new AppUser(){ Id = "edb27c1d-d9de-4ae7-8206-fec010a5004b", UserName = "dalmART_IT", NormalizedUserName ="dalmART_IT".ToUpper(), Email = "artsupport@mail.com", NormalizedEmail = "artsupport@mail.com".ToUpper(), FirstName = "John", LastName ="Doe", PasswordHash = new PasswordHasher<AppUser>().HashPassword(null, "Pa$$w0rd") }
        };


        builder.Entity<AppUser>().HasData(appUsers);
        #endregion

        //Seeding the relation between User and Role to AspNetUserRoles table
        #region Seeding AspNetUserRoles
        List<IdentityUserRole<string>> identityUserRole = new List<IdentityUserRole<string>>()
        {
            new IdentityUserRole<string>() { RoleId = "9ce0f798-67a5-4957-adae-c1e2bb402f74", UserId= "edb27c1d-d9de-4ae7-8206-fec010a5004b"}
        };

        builder.Entity<IdentityUserRole<string>>().HasData(identityUserRole);


        #endregion

    }
}

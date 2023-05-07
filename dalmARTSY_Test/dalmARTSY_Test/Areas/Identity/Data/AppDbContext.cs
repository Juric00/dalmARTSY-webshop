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
            new Product() { Id = 1, CategoryId = 1, Author = "Lukrecija Juric", Title = "The One with Angel", Height = 50, Width = 80, Description = "Description ... update needed ", Frame = false, InStock = 2, Price = 80.99M, ArtCode = "PA100", Image = "the_angel.jpeg" },

            new Product() { Id = 2, CategoryId = 1, Author = "Lukrecija Juric", Title = "The One that Shines", Height = 120, Width = 40, Description = "Description ...update needed", Frame = false, InStock = 1, Price = 120.50M, ArtCode = "PA101", Image = "shining_one.jpeg" },

            new Product() { Id = 3, CategoryId = 1, Author = "Lukrecija Juric", Title = "The Olives", Height = 50, Width = 60, Description = "Description ...update needed", Frame = false, InStock = 1, Price = 50.99M, ArtCode = "PA102", Image = "the_olive.jpeg"},

            new Product() { Id = 4, CategoryId = 1, Author = "Lukrecija Juric", Title = "The Bubble", Height = 40, Width = 65, Description = "Description ...update needed", Frame = true, InStock = 5, Price = 160.00M, ArtCode = "PA103", Image = "bubble.jpeg"},

            new Product() { Id = 5, CategoryId = 1, Author = "Lukrecija Juric", Title = "The Silly PopArt", Height = 120, Width = 50, Description = "Description ...", Frame = true, InStock = 7, Price = 120.99M, ArtCode = "PA104", Image = "the_silly_one.jpeg"},

            new Product() { Id = 6, CategoryId = 1, Author = "Lukrecija Juric", Title = "The One with Two", Height = 120, Width = 50, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "PA105", Image = "the_two.jpeg"},

            new Product() { Id = 7, CategoryId = 1, Author = "Lukrecija Juric", Title = "The Afternoon", Height = 70, Width = 40, Description = "Description ...update needed", Frame = true, InStock = 2, Price = 100M, ArtCode = "PA106", Image = "the_afternoon.jpeg"},

            new Product() { Id = 8, CategoryId = 1, Author = "Lukrecija Juric", Title = "The Dots", Height = 120, Width = 70, Description = "Description ...update needed", Frame = true, InStock = 2, Price = 89.00M, ArtCode = "PA107", Image="dots.jpeg"},

            new Product() { Id = 9, CategoryId = 1, Author = "Lukrecija Juric", Title = "Summers", Height = 40, Width = 60, Description = "Description ...update needed", Frame = false, InStock = 1, Price = 75.00M, ArtCode = "PA108", Image="summer.jpeg"},

            new Product() { Id = 10, CategoryId = 1, Author = "Lukrecija Juric", Title = "Heartsy", Height = 60, Width = 80, Description = "Description ...update needed", Frame = false, InStock = 5, Price = 79.00M, ArtCode = "PA109", Image="heart.jpeg"},

            new Product() { Id = 11, CategoryId = 1, Author = "Lukrecija Juric", Title = "Dalsea and beach", Height = 50, Width = 35, Description = "Description ...update needed", Frame = true, InStock = 1, Price = 90.99M, ArtCode = "PA110", Image="dalsea.jpeg"},

            new Product() { Id = 12, CategoryId = 1, Author = "Lukrecija Juric", Title = "Casual Pop", Height = 120, Width = 70, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "PA111", Image="casual.jpeg"},

            new Product() { Id = 13, CategoryId = 1, Author = "Lukrecija Juric", Title = "Dark Fall", Height = 120, Width = 30, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "PA112",Image="darkfall.jpeg"},

            new Product() { Id = 14, CategoryId = 1, Author = "Lukrecija Juric", Title = "Wingsy", Height = 40, Width = 70, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "PA113",Image="wings.jpeg"},

            new Product() { Id = 15, CategoryId = 1, Author = "Lukrecija Juric", Title = "Objects", Height = 20, Width = 40, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "PA114"},

            new Product() { Id = 16, CategoryId = 1, Author = "Lukrecija Juric", Title = "Fall-in in Love", Height = 20, Width = 40, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "PA115", Image="lovefall.jpeg"},








            new Product() { Id = 17, CategoryId = 2, Author = "Rhamely Wyunko", Title = "The One with Books", Height = 50, Width = 60, Description = "Description ... update needed ", Frame = false, InStock = 2, Price = 80.99M, ArtCode = "PH100", Image = "books.jpeg" },

            new Product() { Id = 18, CategoryId = 2, Author = "Dimitro Franz", Title = "The One with House", Height = 80, Width = 80, Description = "Description ...update needed", Frame = true, InStock = 1, Price = 120.50M, ArtCode = "PH101", Image = "house.jpeg" },

            new Product() { Id = 19, CategoryId = 2, Author = "Daniel Torbekov", Title = "Deep Dive", Height = 100, Width = 120, Description = "Description ...update needed", Frame = false, InStock = 1, Price = 50.99M, ArtCode = "PH102", Image = "deep.jpeg"},

            new Product() { Id = 20, CategoryId = 2, Author = "Chris Cermak", Title = "The Mountain", Height = 40, Width = 40, Description = "Description ...update needed", Frame = true, InStock = 5, Price = 160.00M, ArtCode = "PH103", Image = "mountain.jpeg"},

            new Product() { Id = 21, CategoryId = 2, Author = "Quang Ngueyn", Title = "The Stones", Height = 30, Width = 20, Description = "Description ...", Frame = false, InStock = 7, Price = 24.99M, ArtCode = "PH104", Image = "stones.jpeg"},
            
            
            
            
            
            
            
            new Product() { Id = 22, CategoryId = 3, Author = "Rotislav Uzunov", Title = "The Square", Height = 100, Width = 140, Description = "Description ...update needed", Frame = true, InStock = 3, Price = 70.00M, ArtCode = "DA100", Image = "square.jpeg"},

            new Product() { Id = 23, CategoryId = 3, Author = "Mo Eid", Title = "The Tree", Height = 100, Width = 40, Description = "Description ...update needed", Frame = true, InStock = 2, Price = 50.9M, ArtCode = "DA101",Image = "tree.jpeg"},

            new Product() { Id = 24, CategoryId = 3, Author = "Rodion Kutsayev", Title = "The Doors", Height = 50, Width = 100, Description = "Description ...update needed", Frame = true, InStock = 2, Price = 89.00M, ArtCode = "DA102",Image = "doors.jpeg"},






            new Product() { Id = 25, CategoryId = 4, Author = "Tayla Walls", Title = "The Eye", Height = 40, Width = 60, Description = "Description ...update needed", Frame = true, InStock = 1, Price = 75.00M, ArtCode = "DR100", Image="eye.jpeg"},

            new Product() { Id = 26, CategoryId = 4, Author = "David Guerrero", Title = "The Face", Height = 60, Width = 80, Description = "Description ...update needed", Frame = true, InStock = 5, Price = 79.00M, ArtCode = "DR101", Image="face.jpeg"},







            new Product() { Id = 27, CategoryId = 5, Author = "Steve Johnson", Title = "The Mixy", Height = 100, Width = 140, Description = "Description ...update needed", Frame = true, InStock = 1, Price = 90.99M, ArtCode = "MM100", Image="mixy.jpeg"},

            new Product() { Id = 28, CategoryId = 5, Author = "Velroy Fernandes", Title = "Diving Into", Height = 20, Width = 40, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "MM101", Image="divinginto"},

            new Product() { Id = 29, CategoryId = 5, Author = "Steve Johnson", Title = "The red Dot", Height = 20, Width = 40, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "MM102", Image = "reddot"},

            new Product() { Id = 30, CategoryId = 5, Author = "Zakuskek Ayar", Title = "Zeta Blue", Height = 20, Width = 40, Description = "Description ...update needed", Frame = false, InStock = 3, Price = 70.00M, ArtCode = "MM103", Image = "zeta"}

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

        //Seeding ProductStyles
        #region Seeding ProductStyles
        List<ProductStyle> productStyles = new List<ProductStyle>()
        {
            new ProductStyle() { Id = 1, ProductId = 1, StyleId= 5 },
            new ProductStyle() { Id = 2, ProductId = 2, StyleId= 5 },
            new ProductStyle() { Id = 3, ProductId = 3, StyleId= 5 },
            new ProductStyle() { Id = 4, ProductId = 4, StyleId= 1 },
            new ProductStyle() { Id = 5, ProductId = 5, StyleId= 2 },
            new ProductStyle() { Id = 6, ProductId = 5, StyleId= 3 },
            new ProductStyle() { Id = 7, ProductId = 6, StyleId= 3 },
            new ProductStyle() { Id = 8, ProductId = 7, StyleId= 3 },
            new ProductStyle() { Id = 9, ProductId = 7, StyleId= 5 },
            new ProductStyle() { Id = 10, ProductId = 8, StyleId= 3 },
            new ProductStyle() { Id = 11, ProductId = 8, StyleId= 5 },
            new ProductStyle() { Id = 12, ProductId = 9, StyleId= 5 },
            new ProductStyle() { Id = 13, ProductId = 10, StyleId= 3 },
            new ProductStyle() { Id = 14, ProductId = 10, StyleId= 2 },
            new ProductStyle() { Id = 15, ProductId = 11, StyleId= 5 },
            new ProductStyle() { Id = 16, ProductId = 12, StyleId= 3 },
            new ProductStyle() { Id = 17, ProductId = 13, StyleId= 5 },
            new ProductStyle() { Id = 18, ProductId = 13, StyleId= 1 },
            new ProductStyle() { Id = 19, ProductId = 14, StyleId= 5 },
            new ProductStyle() { Id = 20, ProductId = 14, StyleId= 1 },
            new ProductStyle() { Id = 21, ProductId = 15, StyleId= 1 },
            new ProductStyle() { Id = 22, ProductId = 16, StyleId= 5 },
            new ProductStyle() { Id = 23, ProductId = 16, StyleId= 2 },


            new ProductStyle() { Id = 24, ProductId = 17, StyleId= 5 },
            new ProductStyle() { Id = 25, ProductId = 18, StyleId= 5 },
            new ProductStyle() { Id = 26, ProductId = 19, StyleId= 1 },
            new ProductStyle() { Id = 27, ProductId = 19, StyleId= 2 },
            new ProductStyle() { Id = 28, ProductId = 20, StyleId= 5 },
            new ProductStyle() { Id = 29, ProductId = 21, StyleId= 5 },


            new ProductStyle() { Id = 30, ProductId = 22, StyleId= 5 },
            new ProductStyle() { Id = 31, ProductId = 22, StyleId= 1 },
            new ProductStyle() { Id = 32, ProductId = 23, StyleId= 5 },
            new ProductStyle() { Id = 33, ProductId = 24, StyleId= 1 },
            new ProductStyle() { Id = 34, ProductId = 24, StyleId= 5 },


            new ProductStyle() { Id = 35, ProductId = 25, StyleId= 1 },
            new ProductStyle() { Id = 36, ProductId = 25, StyleId= 2 },
            new ProductStyle() { Id = 37, ProductId = 26, StyleId= 1 },
            new ProductStyle() { Id = 38, ProductId = 26, StyleId= 5 },


            new ProductStyle() { Id = 39, ProductId = 27, StyleId= 4 },
            new ProductStyle() { Id = 40, ProductId = 27, StyleId= 1 },
            new ProductStyle() { Id = 41, ProductId = 27, StyleId= 2 },
            new ProductStyle() { Id = 42, ProductId = 28, StyleId= 1 },
            new ProductStyle() { Id = 43, ProductId = 28, StyleId= 5 },
            new ProductStyle() { Id = 44, ProductId = 29, StyleId= 1 },
            new ProductStyle() { Id = 45, ProductId = 29, StyleId= 2 },
            new ProductStyle() { Id = 46, ProductId = 30, StyleId= 2 }

        };

        builder.Entity<ProductStyle>().HasData(productStyles);

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

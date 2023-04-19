using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using dalmARTSY_Test.Data;
using dalmARTSY_Test.Areas.Identity.Data;
namespace dalmARTSY_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("Default") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false)
            .AddEntityFrameworkStores<AppDbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Create services for using RazorPages options
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}
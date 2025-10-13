using LibraryManagementMVC.DbContext;
using LibraryManagementMVC.Interfaces;
using LibraryManagementMVC.Services;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Dependency Injection (DI) container
            builder.Services.AddScoped<IBookService, BookService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Register EF Core DbContext
            builder.Services.AddDbContext<LibraryDbContext>( options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}

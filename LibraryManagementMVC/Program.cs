using LibraryManagementMVC.Filters;
using LibraryManagementMVC.Interfaces;
using LibraryManagementMVC.Services;
using Microsoft.Extensions.Options;

namespace LibraryManagementMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Dependency Injection (DI) container
            builder.Services.AddScoped<IBookService, OldBookService>();
            builder.Services.AddScoped<IBookService, BookService>(); // standard
            builder.Services.AddScoped<BookService, BookService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddControllersWithViews(options =>
            //    {
            //        //options.Filters.Add(new Filters.CustomAuthFilter())
            //        options.Filters.Add<CustomAuthFilter>();
            //        options.Filters.Add<CustomResourceFilter>();
            //    }   
            //);


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

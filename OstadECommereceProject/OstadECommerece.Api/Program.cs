using Microsoft.EntityFrameworkCore;
using OstadECommerece.Api.Repositories.Interfaces;
using OstadECommerece.Api.Services;
using OstadECommerece.Api.Services.Interfaces;
//using ProductRepository = OstadECommerece.Api.Repositories.ProductRepository;

namespace OstadECommerece.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // dependency injections
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using OstadECommerece.Api.Models;
using OstadECommerece.Api.Repositories;
using OstadECommerece.Api.Repositories.Interfaces;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetProductsWithCategory()
    {
        return _context.Products.Include(p => p.Category).ToList();
    }
}

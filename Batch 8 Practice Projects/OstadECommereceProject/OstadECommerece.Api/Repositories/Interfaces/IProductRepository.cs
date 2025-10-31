using OstadECommerece.Api.Models;

namespace OstadECommerece.Api.Repositories.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetProductsWithCategory(); // only needed for products
    }
}

using OstadECommerece.Api.Models;

namespace OstadECommerece.Api.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product? GetById(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}

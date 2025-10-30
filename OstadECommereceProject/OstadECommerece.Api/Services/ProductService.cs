using OstadECommerece.Api.Models;
using OstadECommerece.Api.Repositories.Interfaces;
using OstadECommerece.Api.Services.Interfaces;

namespace OstadECommerece.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Product> GetAll() => _repo.GetProductsWithCategory();

        public Product? GetById(int id) => _repo.GetById(id);

        public void Create(Product product)
        {
            _repo.Add(product);
            _repo.Save();
        }

        public void Update(Product product)
        {
            _repo.Update(product);
            _repo.Save();
        }

        public void Delete(int id)
        {
            var product = _repo.GetById(id);
            if (product != null)
            {
                _repo.Delete(product);
                _repo.Save();
            }
        }
    }

}

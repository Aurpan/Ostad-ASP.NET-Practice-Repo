using Moq;
using NUnit.Framework;
using OstadECommerece.Api.Repositories.Interfaces;
using OstadECommerece.Api.Services.Interfaces;

namespace OstadECommerece.Api.ServiceUnitTests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private Mock<IProductRepository> _mockRepo;
        private IProductService _service;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IProductRepository>();
            _service = new Services.ProductService(_mockRepo.Object);
        }

        public void GetbyId_ExistingId_ReturnsProduct()
        {
            // Arrange
            var productId = 1;
            var expectedProduct = new Models.Product { Id = productId, Name = "Test Product" };
            _mockRepo.Setup(repo => repo.GetById(productId)).Returns(expectedProduct);
            
            // Act
            var result = _service.GetById(productId);
            
            // Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(expectedProduct.Id, result.Id);
            //Assert.AreEqual(expectedProduct.Name, result.Name);
        }
    }
}

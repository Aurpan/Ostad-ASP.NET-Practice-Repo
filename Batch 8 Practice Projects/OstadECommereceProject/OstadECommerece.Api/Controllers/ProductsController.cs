using Microsoft.AspNetCore.Mvc;
using OstadECommerece.Api.Models;
using OstadECommerece.Api.Services.Interfaces;

namespace OstadECommerece.Api.Controllers
{
    [Route("api/[controller]")] // actual url => https://localhost:7037/api/Products
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products/get
        [HttpGet("get")]
        public IActionResult GetProducts()
        {
            var products = _productService
                .GetAll()
                .ToList();

            return Ok(products);
        }

        // GET: api/Products/getById
        [HttpGet("getById")]
        public IActionResult GetProducts(int productId)
        {
            var product = _productService.GetById(productId);

            return Ok(product);
        }

        // POST: api/Products/add
        [HttpPost("add")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productService.Create(product);
            return Ok();
        }

        // POST: api/Products/update
        [HttpPost("update")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            _productService.Update(product);

            return Ok();
        }
    }
}

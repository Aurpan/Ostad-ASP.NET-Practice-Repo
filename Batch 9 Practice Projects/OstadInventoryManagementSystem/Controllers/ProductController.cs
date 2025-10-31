using Microsoft.AspNetCore.Mvc;
using OstadInventoryManagementSystem.InMemoryDb;
using OstadInventoryManagementSystem.Models;

namespace OstadInventoryManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        //public ProductDB productDb = new ProductDB();

        [HttpGet]
        public IActionResult Products()
        {
            //ProductDB db = new ProductDB();
            var products = ProductDB.Products; // this data should be coming from Database

            //var fromViewData = ViewData["PageHeader"]; // no data available
            //var fromTempData = TempData["PageHeader"]; // data available for one more request

            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int productId)
        {
            //ProductDB db = new ProductDB();
            var selectedProduct = ProductDB.Products
                .Where(p => p.ProductId == productId)
                .FirstOrDefault();

            ViewBag.PageHeader = "Update Product";
            ViewBag.ButtonText = "Update";

            return View(selectedProduct);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var maxProductId = ProductDB.Products.Max(p => p.ProductId);

            ProductViewModel product = new ProductViewModel();
            product.ProductId = maxProductId + 1;

            ViewBag.PageHeader = "Create New Product";
            ViewBag.ButtonText = "Create";

            return View("Edit", product);
        }

        public IActionResult Delete(int productId)
        {
            int index = ProductDB.Products
                .FindIndex(p => p.ProductId == productId);

            if (index >= 0)
                ProductDB.Products.RemoveAt(index);

            return RedirectToAction("Products");
        }

        //public IActionResult Search(string searchValue)
        //{
        //    var filteredProducts = ProductDB.Products
        //        .Where(p => p.ProductName.ToLower()
        //            .Contains(searchValue.ToLower()))
        //        .ToList();

        //    if (index >= 0)
        //        ProductDB.Products.RemoveAt(index);

        //    return RedirectToAction("Products");
        //}

        [HttpPost]
        public IActionResult Update(ProductViewModel product)
        {
            int index = ProductDB.Products
                .FindIndex(p => p.ProductId == product.ProductId);

            if (index < 0)
            {
                // new product
                ProductDB.Products.Add(product);
            }
            else 
            {
                // update existing product
                ProductDB.Products.RemoveAt(index);
                ProductDB.Products.Add(product);
            }

            //ViewData["PageHeader"] = "Create New Product";
            //TempData["PageHeader"] = "Create New Product";

            return RedirectToAction("Products");
        }
    }
}

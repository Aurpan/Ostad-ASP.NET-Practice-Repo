using OstadInventoryManagementSystem.Models;

namespace OstadInventoryManagementSystem.InMemoryDb
{
    public static class ProductDB
    {
        public static List<ProductViewModel> Products = new List<ProductViewModel>()
        {
            new ProductViewModel { ProductId = 1, ProductName = "Laptop", Price = 1200, ProductBrand = "HP", Category = "Electronics" },
            new ProductViewModel { ProductId = 2, ProductName = "Shoes", Price = 60, ProductBrand = "Nike", Category = "Footwear" },
            new ProductViewModel { ProductId = 3, ProductName = "Smartphone", Price = 950, ProductBrand = "Samsung", Category = "Electronics" },
            new ProductViewModel { ProductId = 4, ProductName = "T-Shirt", Price = 25, ProductBrand = "Adidas", Category = "Clothing" },
            new ProductViewModel { ProductId = 5, ProductName = "Backpack", Price = 45, ProductBrand = "Wildcraft", Category = "Accessories" },
            new ProductViewModel { ProductId = 6, ProductName = "Headphones", Price = 120, ProductBrand = "Sony", Category = "Electronics" },
            new ProductViewModel { ProductId = 7, ProductName = "Wrist Watch", Price = 150, ProductBrand = "Casio", Category = "Accessories" },
            new ProductViewModel { ProductId = 8, ProductName = "Jeans", Price = 40, ProductBrand = "Levi’s", Category = "Clothing" },
            new ProductViewModel { ProductId = 9, ProductName = "Blender", Price = 80, ProductBrand = "Philips", Category = "Home Appliances" },
            new ProductViewModel { ProductId = 10, ProductName = "Running Shoes", Price = 75, ProductBrand = "Puma", Category = "Footwear" }
        };
    }
}

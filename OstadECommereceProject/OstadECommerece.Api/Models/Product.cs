namespace OstadECommerece.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }

//    {
//  "name": "Dove Soap",
//  "price": 200.00,
//  "stock": 300,
//  "categoryId": 1
//}
}

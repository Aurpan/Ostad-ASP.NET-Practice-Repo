using System.ComponentModel.DataAnnotations;

namespace OstadInventoryManagementSystem.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [StringLength(100, ErrorMessage = "Max length is 100 chras")]
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}

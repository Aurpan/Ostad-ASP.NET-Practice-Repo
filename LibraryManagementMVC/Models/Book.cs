using System.ComponentModel.DataAnnotations;

namespace LibraryManagementMVC.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Required")]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementMVC.Entities
{
    public class Book
    {
        // Book Entitiy
        public int Id { get; set; }

        [Required, StringLength(200)]
        // Title not null nvarchar(200)
        public string Title { get; set; }

        [Required, StringLength(200)]
        public string Author { get; set; }

        [Required, StringLength(100)]
        public string Genre { get; set; }


        [DefaultValue(false)]
        // IsDeleted null bit (default value 0)
        public bool IsDeleted { get; set; }
    }
}

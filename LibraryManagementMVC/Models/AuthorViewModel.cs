namespace LibraryManagementMVC.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int TotalBooks { get; set; }
    }
}

namespace LibraryManagementMVC.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; }
    }
}

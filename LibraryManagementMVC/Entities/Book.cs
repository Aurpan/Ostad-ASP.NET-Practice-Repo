namespace LibraryManagementMVC.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }
        public bool IsAvailable { get; set; }


        // Navigation Properties
        public Author Author { get; set; }
        public ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}

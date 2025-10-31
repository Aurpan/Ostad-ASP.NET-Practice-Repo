namespace LibraryManagementMVC.Entities
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.UtcNow;
        public DateTime? ReturnDate { get; set; }


        // Navigation Properties
        public Book Book { get; set; } = null!;
        public Member Member { get; set; } = null!;
    }
}

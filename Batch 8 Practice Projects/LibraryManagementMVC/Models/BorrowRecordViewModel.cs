namespace LibraryManagementMVC.Models
{
    public class BorrowRecordViewModel
    {
        public int Id { get; set; }
        public string BookTitle { get; set; } = null!;
        public string MemberName { get; set; } = null!;
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned => ReturnDate != null;
    }
}

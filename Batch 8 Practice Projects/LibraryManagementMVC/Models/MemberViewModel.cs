namespace LibraryManagementMVC.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int TotalBorrowedBooks { get; set; }
    }
}

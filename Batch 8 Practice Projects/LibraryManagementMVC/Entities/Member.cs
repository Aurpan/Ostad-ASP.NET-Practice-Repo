namespace LibraryManagementMVC.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}

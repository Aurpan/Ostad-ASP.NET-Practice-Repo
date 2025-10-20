namespace LibraryManagementMVC.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Navigation Property
        public ICollection<Book> Books { get; set; }
    }
}

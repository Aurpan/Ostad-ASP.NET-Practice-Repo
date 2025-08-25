namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime CollectionDate { get; set; }
        private int AvailableBooks { get; set; } 

        public Book(DateTime collectionDate, int count = 5)
        {
            CollectionDate = collectionDate;
            AvailableBooks = count;
        }

        public Book()
        {
            
        }

        public void Borrow(string collectionDate = "aurgha")
        {
            Console.WriteLine("Borrowing the book!");
            AvailableBooks--;
        }

        public void GetBookCount()
        {
            Console.WriteLine("Available Book: " + AvailableBooks);
        }
    }
}

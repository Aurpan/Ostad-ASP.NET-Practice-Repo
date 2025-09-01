namespace LibraryManagementSystem
{
    public class Book : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime CollectionDate { get; set; }
        private int AvailableBooks { get; set; } 
        //public event Action OnBookBorrowed(int x, int y);

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
            Console.WriteLine("Available Book!");
            GetBookCount("Science", 5);
        }

        // book count by category

        // example of method overloading
        public void GetBookCount(string categoryName)
        {
            Console.WriteLine("Available Book by category");
        }

        public void GetBookCount(string categoryName, int x)
        {
            Console.WriteLine("Available Book by category");
        }

        public void GetBookCount(int x, string categoryName)
        {
            Console.WriteLine("Available Book by category");
        }


        public void GetBookCount(int x)
        {
            Console.WriteLine("Available Book by category");
        }
    }
}

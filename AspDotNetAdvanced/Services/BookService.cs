using AspDotNetAdvanced.CustomExceptions;
using AspDotNetAdvanced.Models;
using AspDotNetAdvanced.Utilities;

namespace AspDotNetAdvanced.Services
{
    public class BookService
    {
        public List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99m, PublishedDate = new DateTime(1925, 4, 10), Genre = "Fiction" },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 7.99m, PublishedDate = new DateTime(1960, 7, 11), Genre = "Fiction" },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Price = 8.99m, PublishedDate = new DateTime(1949, 6, 8), Genre = "Dystopian" },
            new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Price = 6.99m, PublishedDate = new DateTime(1813, 1, 28), Genre = "Romance" },
            new Book { Id = 5, Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 12.99m, PublishedDate = new DateTime(1937, 9, 21), Genre = "Fantasy" },
            new Book { Id = 6, Title = "The Silent Patient", Author = "Alex Michaelides", Price = 14.99m, PublishedDate = new DateTime(2019, 2, 5), Genre = "Thriller" },
            new Book { Id = 7, Title = "Atomic Habits", Author = "James Clear", Price = 18.50m, PublishedDate = new DateTime(2018, 10, 16), Genre = "Self-Help" },
            new Book { Id = 8, Title = "Educated", Author = "Tara Westover", Price = 16.99m, PublishedDate = new DateTime(2018, 2, 20), Genre = "Memoir" },
            new Book { Id = 9, Title = "Where the Crawdads Sing", Author = "Delia Owens", Price = 12.75m, PublishedDate = new DateTime(2018, 8, 14), Genre = "Fiction" },
            new Book { Id = 10, Title = "Project Hail Mary", Author = "Andy Weir", Price = 22.00m, PublishedDate = new DateTime(2021, 5, 4), Genre = "Science Fiction" },
            new Book { Id = 11, Title = "The Midnight Library", Author = "Matt Haig", Price = 15.40m, PublishedDate = new DateTime(2020, 9, 29), Genre = "Fantasy" },
            new Book { Id = 12, Title = "Becoming", Author = "Michelle Obama", Price = 19.95m, PublishedDate = new DateTime(2018, 11, 13), Genre = "Biography" },
            new Book { Id = 13, Title = "The Alchemist", Author = "Paulo Coelho", Price = 10.99m, PublishedDate = new DateTime(1988, 4, 15), Genre = "Adventure" },
            new Book { Id = 14, Title = "Dune", Author = "Frank Herbert", Price = 21.50m, PublishedDate = new DateTime(1965, 8, 1), Genre = "Science Fiction" },
            new Book { Id = 15, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 9.99m, PublishedDate = new DateTime(1925, 4, 10), Genre = "Classic" }
        };

        public Book GetBookById(int bookId)
        {
            // fetch data from database => books
            var selectedBook = books.Find(b => b.Id == bookId);

            if (selectedBook == null)
            {
                throw new MyCustomException("Baari Khaise!");
            }

            return selectedBook;
        }

        public List<Book> GetBooksByPriceRange(decimal lowerRange, decimal higherRange)
        {
            // fetch data from database => books
            var filteredBooks = books
                .Where(book => book.Price >= lowerRange && book.Price <= higherRange)
                .ToList();

            return filteredBooks;
        }

        //public string GetCommaSeparatedBookTitles()
        //{
        //    // Harry Potter, The Hobbit, The Great Gatsby
        //    var titles = books.Select(book => book.Title);
        //    return string.Join(", ", titles);
        //}

        //public string GetCommaSeparatedBookAuthors()
        //{
        //    // Harry Potter, The Hobbit, The Great Gatsby
        //    var authors = books.Select(book => book.Author);
        //    return string.Join(", ", authors);
        //}
        //public string GetCommaSeparatedValue(Func<Book, string> colCondition)
        //{
        //    List<string> strValues = new List<string>();
        //    foreach (var book in books)
        //    {
        //        var value = colCondition(book);
        //        if (value != null)
        //        {
        //            strValues.Add(value.ToString());
        //        }
        //    }

        //    Console.WriteLine(string.Join(", ", strValues));

        //    return string.Join(", ", strValues);
        //}

        public string GetCommaSeparatedValue(Func<Book, string> colCondition)
        {
            return books.GetCommaSeparatedValue(colCondition);
        }

        public decimal CalculateSum(List<decimal> nums)
        {
            var result = ExtensioMethods.GetSumNormal(nums);
            nums.GetSum().PrintDecimal();
            return result;
            //return nums.GetSum();
        }

        //public void LambdaDemo(int num, Func<int, int> sqr)
        //{
        //    int result = sqr(num);

        //    Console.WriteLine($"The result is {result}");
        //}
    }
}

using LibraryManagementMVC.Interfaces;
using LibraryManagementMVC.Models;

namespace LibraryManagementMVC.Services
{
    public class BookService : IBookService
    {
        public List<Book> GetAllBooks()
        {
            // database call to fetch all books

            var books = new List<Book>
            {
                new Book { Id = 1, Title = "1984", Author = "George Orwell", Genre = "Dystopian" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction" },
            };

            return books;
        }

        public void TestMethod()
        {
            var books = new List<BookViewModel>
            {
                new BookViewModel { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic" },
                new BookViewModel { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic" },
                new BookViewModel { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian" },
                new BookViewModel { Id = 4, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction" },
                new BookViewModel { Id = 5, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance" },
                new BookViewModel { Id = 6, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy" },
                new BookViewModel { Id = 7, Title = "Moby Dick", Author = "Herman Melville", Genre = "Adventure" },
                new BookViewModel { Id = 8, Title = "War and Peace", Author = "Leo Tolstoy", Genre = "Historical" },
                new BookViewModel { Id = 9, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Philosophical" },
                new BookViewModel { Id = 10, Title = "Harry Potter and the Sorcerer’s Stone", Author = "J.K. Rowling", Genre = "Fantasy" }
            };



        }
    }
}

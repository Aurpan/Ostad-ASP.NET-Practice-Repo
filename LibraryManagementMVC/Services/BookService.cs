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

    }
}

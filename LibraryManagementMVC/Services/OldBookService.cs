using LibraryManagementMVC.Interfaces;
using LibraryManagementMVC.Models;

namespace LibraryManagementMVC.Services
{
    public class OldBookService : IBookService
    {
        public List<Book> GetAllBooks()
        {
            var books = new List<Book>
            {
                new Book { Id = 1, Title = "1984", Author = "George Orwell", Genre = "Dystopian" },
            };

            return books;
        }
    }
}

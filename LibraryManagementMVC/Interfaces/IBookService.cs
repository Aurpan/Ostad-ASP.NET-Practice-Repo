using LibraryManagementMVC.Models;

namespace LibraryManagementMVC.Interfaces
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
    }
}

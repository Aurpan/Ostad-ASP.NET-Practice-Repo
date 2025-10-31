using LibraryManagementMVC.Models;

namespace LibraryManagementMVC.Services.Interfaces
{
    public interface IBookService
    {
        public List<BookViewModel> GetAllBooks();
        BookViewModel GetBookById(int bookId);
        void Update(BookViewModel book);
    }
}

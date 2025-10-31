using LibraryManagementMVC.Entities;

namespace LibraryManagementMVC.Repositories.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        IEnumerable<Book> GetAvailableBooks();
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        void SaveChanges();
    }
}

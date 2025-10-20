using LibraryManagementMVC.DbContext;
using LibraryManagementMVC.Entities;
using LibraryManagementMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

public class BookRepository : IBookRepository
{
    private readonly LibraryDbContext _context;

    public BookRepository(LibraryDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Book> GetAll()
    {
        return _context.Books.Include(b => b.Author).ToList();
    }

    public Book GetById(int id)
    {
        var result = _context.Books
            .Include(b => b.Author)
            .FirstOrDefault(b => b.BookId == id);

        return result;
    }

    public void Add(Book book)
    {
        _context.Books.Add(book);
    }

    public void Update(Book book)
    {
        _context.Books.Update(book);
    }

    public void Delete(Book book)
    {
        _context.Books.Remove(book);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public IEnumerable<Book> GetAvailableBooks()
    {
        throw new NotImplementedException();
    }
}

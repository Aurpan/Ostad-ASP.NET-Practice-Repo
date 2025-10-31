using LibraryManagementMVC.Entities;
using LibraryManagementMVC.Models;
using LibraryManagementMVC.Repositories.Interfaces;
using LibraryManagementMVC.Services.Interfaces;

namespace LibraryManagementMVC.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<BookViewModel> GetAllBooks()
        {
            var books = _bookRepository
                .GetAll()
                .ToList();

            return MapBookEntityListToViewModelList(books);
        }


        public void Update(BookViewModel book)
        {
            var bookEntity = _bookRepository.GetById(book.Id); 

            if (bookEntity != null)
            {
                bookEntity.Title = book.Title;
                bookEntity.ISBN = book.ISBN;
                bookEntity.IsAvailable = book.IsAvailable;
                bookEntity.Author.Name = book.AuthorName;

                _bookRepository.Update(bookEntity);
                _bookRepository.SaveChanges();
            }
        }

        public BookViewModel GetBookById(int bookId)
        {
            var book = _bookRepository.GetById(bookId);
            if (book != null)
            {
                return MapBookEntityToViewModel(book);
            }
            return null;
        }




        // create book entity to view model mapper

        public BookViewModel MapBookEntityToViewModel(Book book)
        {
            return new BookViewModel
            {
                Id = book.BookId,
                Title = book.Title,
                ISBN = book.ISBN,
                IsAvailable = book.IsAvailable,
                AuthorName = book.Author.Name
            };
        }

        public List<BookViewModel> MapBookEntityListToViewModelList(List<Book> books)
        {
            var bookViewModelList = new List<BookViewModel>();
            foreach (var book in books)
            {
                bookViewModelList.Add(MapBookEntityToViewModel(book));
            }
            return bookViewModelList;
        }
    }
}

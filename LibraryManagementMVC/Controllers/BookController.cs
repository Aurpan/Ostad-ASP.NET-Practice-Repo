using LibraryManagementMVC.Interfaces;
using LibraryManagementMVC.Models;
using LibraryManagementMVC.Services;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementMVC.Filters;

namespace LibraryManagementMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookServices)
        {
            _bookService = bookServices;
        }

        // fetches all books
        public IActionResult Books() 
        {
            var books = _bookService.GetAllBooks();

            return View(books); 
        }



        // Edit book 
        //public IActionResult Edit(int bookId, string bookTitle)
        //public IActionResult Edit(int bookId)
        //{
        //    var selectedBook = _books.FirstOrDefault(b => b.Id == bookId);

        //    return View(selectedBook);
        //}

        //[HttpPost] // attribute
        //[CustomResourceFilter]
        //public IActionResult Update(BookViewModel updatedBook)
        //{
        //    var book = _books.FirstOrDefault(b => b.Id == updatedBook.Id);

        //    book.Author = updatedBook.Author;
        //    book.Title = updatedBook.Title;
        //    book.Genre = updatedBook.Genre;

        //    return RedirectToAction("Books");
        //    //return View("Books", _books); // bad practice
        //}

        //public IActionResult Delete(int bookId)
        //{
        //    var selectedBook = _books.FirstOrDefault(b => b.Id == bookId);
        //    // how to remove an item from a list

        //    return RedirectToAction("Books");
        //}


        //private void CreateDummyBookList()
        //{
        //    //List<BookViewModel> books = new List<BookViewModel>();

        //    BookViewModel book1 = new BookViewModel()
        //    {
        //        Id = 1,
        //        Title = "The Great Gatsby",
        //        Author = "F. Scott Fitzgerald",
        //        Genre = "Fiction"
        //    };
        //    //BookViewModel book1 = new BookViewModel();
        //    //book1.Id = 1;
        //    //book1.Title = "The Great Gatsby";   
        //    //book1.Author = "F. Scott Fitzgerald";
        //    //book1.Genre = "Fiction";

        //    BookViewModel book2 = new BookViewModel()
        //    {
        //        Id = 2,
        //        Title = "The Great Gatsby 12",
        //        Author = "Fitzgerald",
        //        Genre = "Horror"
        //    };

        //    _books.Add(book1);
        //    _books.Add(book2);
        //}
    }
}

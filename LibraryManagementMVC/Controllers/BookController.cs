using LibraryManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementMVC.Controllers
{
    public class BookController : Controller
    {
        // fetches all books
        public IActionResult Books()
        {
            var books = GetDummyBookList();

            return View(books);
        }

        private List<BookViewModel> GetDummyBookList()
        {
            List<BookViewModel> books = new List<BookViewModel>();

            BookViewModel book1 = new BookViewModel()
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Fiction"
            };
            //BookViewModel book1 = new BookViewModel();
            //book1.Id = 1;
            //book1.Title = "The Great Gatsby";   
            //book1.Author = "F. Scott Fitzgerald";
            //book1.Genre = "Fiction";

            BookViewModel book2 = new BookViewModel()
            {
                Id = 2,
                Title = "The Great Gatsby 12",
                Author = "Fitzgerald",
                Genre = "Horror"
            };

            books.Add(book1);
            books.Add(book2);

            return books;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LocalDB
    {
        public static List<Book> Books = new List<Book>();

        public static void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}

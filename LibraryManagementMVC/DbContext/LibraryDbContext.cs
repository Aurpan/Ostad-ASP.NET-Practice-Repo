using LibraryManagementMVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementMVC.DbContext
{
    public class LibraryDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options) // this is ctor from base class
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}

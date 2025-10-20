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
        public DbSet<Author> Authors { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations from the current assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace TP04.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

// Miguel Pataro CB3021564 e Lucas Vieira CB3020223
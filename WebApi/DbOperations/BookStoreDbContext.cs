using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.DbOperations
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext>options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(

                    new Book { Title = "Game of Thrones", PageCount = 300, GenreId = 1, PublishDate = new DateTime(1998, 06, 18) },
                    new Book { Title = "A Song of Ice nd Fire", PageCount = 250, GenreId = 2, PublishDate = new DateTime(2001, 06, 18) },
                    new Book { Title = "A Dance with Dragons", PageCount = 350, GenreId = 3, PublishDate = new DateTime(2002, 06, 18) },
                    new Book { Title = "Lord of the Rings", PageCount = 200, GenreId = 2, PublishDate = new DateTime(2001, 06, 18) }
                    );
                context.SaveChanges();
            }
        }
    }
}
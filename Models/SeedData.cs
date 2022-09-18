using Library.Data;
using Microsoft.EntityFrameworkCore;



namespace Library.Models
{
    public static class SeedData
    {

       
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new LibraryContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<LibraryContext>>()))
                {
                    // Look for any books.
                    if (context.Book.Any())
                    {
                        return;   // DB has been seeded
                    }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Lord of the Rings",
                        Available = "Available"

                    },

                    new Book
                    {
                        Title = "Lord of the Rings",
                        Available = "Available"
                    },

                    new Book
                    {
                        Title = "Wizard of Oz",
                        Available = "Available"
                    },

                    new Book
                    {
                        Title = "How to write a good ASP.NET Core web app",
                        Available = "Available"
                    }
                ) ;
                ;

                context.SaveChanges();
                }
            }
        }

}


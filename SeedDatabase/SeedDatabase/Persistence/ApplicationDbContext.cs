using Microsoft.EntityFrameworkCore;
using SeedDatabase.Models;

namespace SeedDatabase.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get;set;}
        public DbSet<Book> Books { get;set;}
    }
}

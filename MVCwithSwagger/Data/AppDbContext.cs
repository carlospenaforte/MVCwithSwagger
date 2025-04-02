using Microsoft.EntityFrameworkCore;
using MVCwithSwagger.Models;

namespace MVCwithSwagger.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<BookModel> Books { get; set; }

    }
}

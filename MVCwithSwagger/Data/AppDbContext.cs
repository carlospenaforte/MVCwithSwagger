using Microsoft.EntityFrameworkCore;
using MVCwithSwagger.Models;

namespace MVCwithSwagger.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<BookModel> Books { get; set; }

    }
}

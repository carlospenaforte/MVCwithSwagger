using Microsoft.EntityFrameworkCore;

namespace MVCwithSwagger.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}

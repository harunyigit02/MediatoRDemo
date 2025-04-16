using MediatoRTestApi.Database;
using Microsoft.EntityFrameworkCore;

namespace MediatoRTestApi.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}

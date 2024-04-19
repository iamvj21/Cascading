using Cascading.Models;
using Microsoft.EntityFrameworkCore;

namespace Cascading.Data
{
    public class CascadingDbContext : DbContext
    {
        public CascadingDbContext(DbContextOptions<CascadingDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
    }
}

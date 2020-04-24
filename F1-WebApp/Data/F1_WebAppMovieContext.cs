using Microsoft.EntityFrameworkCore;

namespace F1_WebApp.Data
{
    public class F1_WebAppMovieContext : DbContext
    {
        public F1_WebAppMovieContext(DbContextOptions<F1_WebAppMovieContext> options)
            : base(options)
        {
        }

        public DbSet<F1_WebApp.Models.Movie> Movie { get; set; }
    }
}
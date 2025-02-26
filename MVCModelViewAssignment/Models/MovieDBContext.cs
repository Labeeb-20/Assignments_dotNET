using Microsoft.EntityFrameworkCore;

namespace MVCModelViewAssignment.Models
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options) { 
        
        }

        public DbSet<Movie> Movie { get; set; }
    }
}

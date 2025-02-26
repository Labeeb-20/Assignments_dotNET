using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MVCAssignment3.Models
{
    public class HallDBContext:DbContext
    {
        public HallDBContext(DbContextOptions<HallDBContext> options) : base(options)
        {
            
        }

        public DbSet<Hall> Halls { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace EmployeesWebAPI.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) 
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

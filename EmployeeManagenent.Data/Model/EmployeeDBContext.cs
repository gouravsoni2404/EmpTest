using Microsoft.EntityFrameworkCore;

namespace EmployeeManagenent.Data.Model
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
        : base(options)
        {

        }

        
    }
}

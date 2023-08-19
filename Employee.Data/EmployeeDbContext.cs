using EmployeeService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeService.Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ITT-GOURAVS;Database=EmployeeDB;User Id=sa;Password=Password@123;TrustServerCertificate=true;");
        }
    }
}
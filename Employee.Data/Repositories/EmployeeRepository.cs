using EmployeeService.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Data.Repositories
{
    public class EmployeeRepository : EmployeeDbContext, IEmployeeRepository
    {
        public EmployeeRepository(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public Employee Get(int id)
        {
            return Employees.FirstOrDefault(emp => emp.Id == id);
        }

        public void Add(Employee employee)
        {
            Employees.Add(employee);
            SaveChanges();
        }

        public void Update(Employee employee)
        {
            Employees.Update(employee);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = new Employee { Id = id };
            Employees.Entry(emp).State = EntityState.Deleted;
            SaveChanges();
        }

    }
}

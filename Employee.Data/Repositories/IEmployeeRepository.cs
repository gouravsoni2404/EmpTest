using EmployeeService.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Data.Repositories
{
    public interface IEmployeeRepository
    {
        Employee Get(int id);
        void Add(Employee employee);
        void Update(Employee employee);

        void Delete(int id);

    }
}

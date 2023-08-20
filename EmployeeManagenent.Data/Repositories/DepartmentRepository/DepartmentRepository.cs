using EmployeeManagenent.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagenent.Data.Repositories.DepartmentRepository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(EmployeeDBContext _context) : base(_context)
        {
        }
    }
}

using EmployeeManagenent.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagenent.Data
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBContext Context) : base(Context)
        {

        }

        public override IEnumerable<Employee> GetAll()
        {
            return table.Include(employee => employee.Department).AsEnumerable();
        }

        public override Employee GetById(object id)
        {
            return table.Include(employee => employee.Department).FirstOrDefault(employee => employee.Id == (int)id);
        }
    }
}

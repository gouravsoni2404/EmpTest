using Contracts = EmployeeManagenent.Contracts;

namespace EmployeeManagenent.Data.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public static implicit operator Contracts.Employee(Employee employeeModel)
        {
            return new Contracts.Employee()
            {
                Id = employeeModel.Id,
                Name = employeeModel.Name,
                DateOfJoining = employeeModel.DateOfJoining,
                DepartmentId = employeeModel.DepartmentId,
                Department = employeeModel.Department,
            };
        }

        public static implicit operator Employee(Contracts.Employee employeeContract)
        {
            return new Employee()
            {
                Id = employeeContract.Id,
                Name = employeeContract.Name,
                DateOfJoining = employeeContract.DateOfJoining,
                DepartmentId = employeeContract.DepartmentId,
                Department = employeeContract.Department,
            };
        }
    }
}

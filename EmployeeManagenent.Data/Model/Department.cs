using Contracts = EmployeeManagenent.Contracts;

namespace EmployeeManagenent.Data.Model
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static implicit operator Contracts.Department(Department departmentModel)
        {
            if (departmentModel == null) return null;
            return new Contracts.Department()
            {
                Id = departmentModel.Id,
                Name = departmentModel.Name,
            };
        }

        public static implicit operator Department(Contracts.Department departmentContracts)
        {
            if (departmentContracts == null) return null;
            return new Department()
            {
                Id = departmentContracts.Id,
                Name = departmentContracts.Name,
            };
        }
    }
}

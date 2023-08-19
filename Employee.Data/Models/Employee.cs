namespace EmployeeService.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}

namespace EmployeeService.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfJoining { get; set; }

        public Department Department { get; set; }

    }
}

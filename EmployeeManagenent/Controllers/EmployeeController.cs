using EmployeeManagenent.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagenent.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IEnumerable<Contracts.Employee> Get()
        {
            return _employeeRepository.GetAll().Select(employeeModel => (Contracts.Employee) employeeModel);
        }

        [HttpGet("{id}")]
        public Contracts.Employee Get(int id)
        {
            return _employeeRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Contracts.Employee employee)
        {
            _employeeRepository.Insert(employee);
        }

        [HttpPut]
        public void Put([FromBody] Contracts.Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeRepository.Delete(id);
        }
    }
}

using EmployeeService.Data.Models;
using EmployeeService.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
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
        public async Task<IActionResult> Get(int id)
        {
            var result = Task.Run(() => _employeeRepository.Get(id));
            if(result.Result != null)
            {
                return Ok(result);
            }
            return NotFound("Employee not found");
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            _employeeRepository.Add(employee);
            return Created("Employee Created", null);
        }
        //void Update(Employee employee);

        //void Delete(int id);
    }
}

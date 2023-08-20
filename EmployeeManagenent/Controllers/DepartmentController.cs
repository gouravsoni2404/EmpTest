using EmployeeManagenent.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagenent.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public IEnumerable<Contracts.Department> Get()
        {
            return _departmentRepository.GetAll().Select(departmentModel => (Contracts.Department)departmentModel);
        }

        [HttpGet("{id}")]
        public Contracts.Department Get(int id)
        {
            return _departmentRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Contracts.Department department)
        {
            _departmentRepository.Insert(department);
        }

        [HttpPut]
        public void Put([FromBody] Contracts.Department department)
        {
            _departmentRepository.Update(department);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _departmentRepository.Delete(id);
        }
    }
}

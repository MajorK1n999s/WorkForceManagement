using Microsoft.AspNetCore.Mvc;
using WFM.Application.Interfaces.Repositories;
using WFM.Domain.Entities;
using WFM.Application.DTOs.Employee;
using WorkForceManagement.Mappers;

namespace WorkForceManagement.Controllers
{
    // API Endpoint for Employee table operations
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        // Repository inject by DI
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeRepository.GetAllAsync();
            var result = employees.Select(EmployeeMapper.ToDto); // Map DTO's to API
            return Ok(result);
        }

        // GET: api/Employees/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(Guid id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);

            if (employee == null)
            {
                return NotFound("Employee not found");
            }
            return Ok(employee);
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto cdto)
        {
            // Model validation check
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var employee = EmployeeMapper.ToEntity(cdto);
            await _employeeRepository.AddAsync(employee);
            return Ok("Employee created successfully");
        }
    }
}

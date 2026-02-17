using Microsoft.AspNetCore.Mvc;
using WorkForceManagement.Mappers;
using WFM.Application.DTOs.Task;
using WFM.Application.Interfaces.Repositories;
using WFM.Infrastructure.Repositories;

namespace WorkForceManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly TaskRepository _taskRepository;

        public TasksController(TaskRepository taskRepository) // DI
        {
            _taskRepository = taskRepository;
        }

        // POST: api/Tasks
        [HttpPost]
        public async Task<IActionResult> AssignTask(CreateTaskDto ctdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var task = TaskMapper.ToEntity(ctdto);
            await _taskRepository.AddAsync(task);
            return Ok("Task assigned successfully.");
        }

        // GET: api/Tasks/Employee/{employeeId}
        public async Task<IActionResult> GetTasksFromEmployee(Guid employeeId)
        {
            var tasks = await _taskRepository.GetByEmployeeIdAsync(employeeId);
            return Ok(tasks);
        }
    }
}

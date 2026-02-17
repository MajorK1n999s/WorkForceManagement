using WFM.Application.DTOs.Task;

namespace WFM.Application.Interfaces.Services
{
    // Business logic related to tasks
    public interface ITaskService
    {
        Task AssignTaskAsync(CreateTaskDto task);

        Task<IEnumerable<CreateTaskDto>> GetTasksByEmployeeIdAsync(Guid employeeId);
    }
}

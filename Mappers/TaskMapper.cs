using WFM.Application.DTOs.Task;
using WFM.Domain.Entities;
using WFM.Domain.Enums;

namespace WorkForceManagement.Mappers
{
    // Maps tasks DTO to entity and back
    public static class TaskMapper
    {
        public static TaskItem ToEntity(CreateTaskDto dto)
        {
            return new TaskItem
            {
                Title = dto.Title,
                Description = dto.Description,
                AssignedToEmployeeId = dto.AssignedToEmployeeId,
                AssignedByEmployeeId = dto.AssignedByEmployeeId,
                DueDate = dto.DueDate,
                Status = Taskstatus.Pending
            };
        }
    }
}

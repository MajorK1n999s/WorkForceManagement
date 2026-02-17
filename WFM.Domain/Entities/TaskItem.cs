using WFM.Domain.Common;
using WFM.Domain.Enums;

namespace WFM.Domain.Entities
{
    // Represents a task assigned to an employee
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid AssignedToEmployeeId { get; set; }
        public Guid AssignedByEmployeeId { get; set; }
        public DateTime DueDate { get; set; }
        public Taskstatus Status { get; set; } = Taskstatus.Pending;
    }
}

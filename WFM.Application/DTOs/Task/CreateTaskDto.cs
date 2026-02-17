using System.ComponentModel.DataAnnotations;

namespace WFM.Application.DTOs.Task
{
    // Use when assigned the task
    public class CreateTaskDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Required]
        public Guid AssignedToEmployeeId { get; set; }

        [Required]
        public Guid AssignedByEmployeeId { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
    }
}

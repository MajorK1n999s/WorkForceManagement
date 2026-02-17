using System.ComponentModel.DataAnnotations;

namespace WFM.Application.DTOs.Attendance
{
    // Use when employee check in
    public class CheckInDto
    {
        [Required]
        public Guid EmployeeId { get; set; }
    }
}

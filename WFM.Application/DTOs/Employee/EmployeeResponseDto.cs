

namespace WFM.Application.DTOs.Employee
{
    // Data sent back to UI
    public class EmployeeResponseDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public DateTime JoiningDate { get; set; }
    }
}

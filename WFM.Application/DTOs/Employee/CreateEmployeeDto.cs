using System.ComponentModel.DataAnnotations;

namespace WFM.Application.DTOs.Employee
{
    //Data sent to UI
    // Use when creating new employee
    public class CreateEmployeeDto
    {
        [Required] // validation attribute (mandatory field)
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        //Role will come as number (1,2,3,4)
        [Range(1,4)]
        public int Role { get; set; }

        [Required]
        public DateTime JoiningDate { get; set; }
    }
}

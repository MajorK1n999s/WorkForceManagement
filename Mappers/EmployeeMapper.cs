using WFM.Application.DTOs.Employee;
using WFM.Domain.Entities;
using WFM.Domain.Enums;

namespace WorkForceManagement.Mappers
{
    //Converts between Entity and DTO's
    public static class EmployeeMapper
    {
        public static Employee ToEntity(CreateEmployeeDto dto)
        {
            return new Employee
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Role = (RoleType)dto.Role,
                JoiningDate = dto.JoiningDate
            };
        }

        public static EmployeeResponseDto ToDto(Employee employee)
        {
            return new EmployeeResponseDto
            {
                Id = employee.Id,
                FullName = $"{employee.FirstName} {employee.LastName}",
                Role = employee.Role.ToString(),
                JoiningDate = employee.JoiningDate
            };
        }
    }
}

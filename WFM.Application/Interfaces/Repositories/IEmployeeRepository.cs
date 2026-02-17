using WFM.Domain.Entities;

namespace WFM.Application.Interfaces.Repositories
{
    // Contract for Employee data access
    public interface IEmployeeRepository
    {
        Task<Employee?> GetByIdAsync(Guid id);
        Task<IEnumerable<Employee>> GetAllAsync();
        Task AddAsync(Employee employee);
    }
}

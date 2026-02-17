using Microsoft.EntityFrameworkCore;
using WFM.Domain.Entities;
using WFM.Infrastructure.Persistence.Context;
using WFM.Application.Interfaces.Repositories;

namespace WFM.Infrastructure.Repositories
{
    // Handle employee tables database operations
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly WfmDbContext _context;

        public EmployeeRepository(WfmDbContext context)
        {
            _context = context;
        }

        // Get employee by Id
        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        // Get all employees
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        // Add new employee
        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

    }
}

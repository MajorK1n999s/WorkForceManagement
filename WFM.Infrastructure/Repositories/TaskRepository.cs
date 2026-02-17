using Microsoft.EntityFrameworkCore;
using WFM.Domain.Entities;
using WFM.Infrastructure.Persistence.Context;

namespace WFM.Infrastructure.Repositories
{
    // Handle task database operations
    public class TaskRepository
    {
        private readonly WfmDbContext _context;

        public TaskRepository(WfmDbContext context) // DI
        {
            _context = context;
        }

        public async Task AddAsync(TaskItem task) // Add new task
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        // Get tasks by employee
        public async Task<IEnumerable<TaskItem>> GetByEmployeeIdAsync(Guid employeeId)
        {
            return await _context.Tasks
                .Where(t => t.AssignedToEmployeeId == employeeId)
                .ToListAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using WFM.Domain.Entities;
using WFM.Infrastructure.Persistence.Context;
using WFM.Domain.Enums;

namespace WFM.Infrastructure.Repositories
{
    // Handle attendance database operations
    public class AttendanceRepository
    {
        private readonly WfmDbContext _context;
        public AttendanceRepository(WfmDbContext context) // DI
        {
            _context = context;
        }


        // Add a check-in record for an employee
        public async Task CheckInAsync(Guid employeeId)
        {
            var attendance = new Attendance
            {
                EmployeeId = employeeId,
                Date = DateTime.UtcNow.Date,
                CheckInTime = DateTime.UtcNow,
                Status = AttendanceStatus.Present
            };

            await _context.Attendances.AddAsync(attendance);
            await _context.SaveChangesAsync();
        }  
    }
}

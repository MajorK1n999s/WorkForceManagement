using WFM.Domain.Common;
using WFM.Domain.Enums;

namespace WFM.Domain.Entities
{
    // Attendance record for an employee
    public class Attendance : BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public AttendanceStatus Status { get; set; }
    }
}

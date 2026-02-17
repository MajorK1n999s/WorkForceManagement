using Microsoft.AspNetCore.Mvc;
using WFM.Infrastructure.Repositories;
using WFM.Application.DTOs.Attendance;


namespace WorkForceManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceRepository _attendanceRepository;
        public AttendanceController(AttendanceRepository attendanceRepository) // DI
        {
            _attendanceRepository = attendanceRepository;
        }

        // Post: api/attendance/checkin
        [HttpPost("checkin")]
        public async Task<IActionResult> CheckIn(CheckInDto cidto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _attendanceRepository.CheckInAsync(cidto.EmployeeId);
            return Ok("Check-in successful.");
        }

    }
}

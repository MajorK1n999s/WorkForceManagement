using WFM.Domain.Common;

namespace WFM.Domain.Entities
{
    // Store employee contact details
    public class EmployeeContact : BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public string MobileNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Pincode { get; set; } = string.Empty;
    }
}

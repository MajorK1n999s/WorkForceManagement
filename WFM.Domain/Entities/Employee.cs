using WFM.Domain.Common;
using WFM.Domain.Enums;

namespace WFM.Domain.Entities
{
    // main employee entity
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public RoleType Role { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

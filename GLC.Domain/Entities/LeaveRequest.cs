using CompanyPortal.Domain.Entities;

namespace GLC.Domain.Entities
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveStatus Status { get; set; } = LeaveStatus.Pending;
        public string? Reason { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public virtual Employee Employee { get; set; } = null!;
    }

    public enum LeaveStatus
    {
        Pending,
        Approved,
        Rejected
    }
}

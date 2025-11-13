using CompanyPortal.Domain.Entities;

namespace GLC.Domain.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        public virtual Employee Employee { get; set; } = null!;
    }
}

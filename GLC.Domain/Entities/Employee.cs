

using GLC.Domain.Entities;

namespace CompanyPortal.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int? ManagerId { get; set; }
    public int DepartmentId { get; set; }

    public virtual Employee? Manager { get; set; }
    public virtual Department Department { get; set; } = null!;
    public virtual Salary? Salary { get; set; }
    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
}


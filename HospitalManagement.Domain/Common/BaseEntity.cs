namespace HospitalManagement.Domain.Common;

public abstract class BaseEntity
{
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime DateModified { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "ADMIN";
    public string? ModifiedBy { get; set;}
    public bool IsDeleted { get; set; } = false;
    public Guid Id { get; set; }
}

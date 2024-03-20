namespace HospitalManagement.Domain.Common;

public abstract class BaseEntity
{
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set;}
    public bool IsDeleted { get; set; } = false;
    public Guid Id { get; set; }
}

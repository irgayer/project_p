namespace ProjectP.Domain.Primitives;

public abstract class AuditableEntity : Entity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

using ProjectP.Domain.Primitives;

namespace ProjectP.Domain.Entities;

public class Post : AuditableEntity
{
    public User User { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
}

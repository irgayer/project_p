using ProjectP.Domain.Primitives;

namespace ProjectP.Domain.Entities;

public class Subscription : Entity
{
    public User User { get; set; }
    public int UserId { get; set; }
    public User Friend { get; set; }
    public int FriendId { get; set; }
}

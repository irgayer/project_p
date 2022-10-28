using ProjectP.Domain.Primitives;

namespace ProjectP.Domain.Entities;

public class User : Entity
{
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Biography Biography { get; set; }
}

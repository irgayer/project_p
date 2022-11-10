using ProjectP.Domain.Builders;
using ProjectP.Domain.Primitives;

namespace ProjectP.Domain.Entities;

public class Biography : Entity
{
    public string? AboutMe { get; set; }
    public string? Address { get; set; }
    public string? ZipCode { get; set; }
    public string? YouTube { get; set; }
    public string? Facebook { get; set; }

    public User User { get; set; }
    public int UserId { get; set; }

    public static BiographyBuilder Builder(User user)
    {
        return new BiographyBuilder(user);
    }
}

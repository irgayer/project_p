using ProjectP.Domain.Entities;

namespace ProjectP.Application.Core.Abstractions.Authentication;

public interface IJwtProvider
{
    string Create(User user);
}

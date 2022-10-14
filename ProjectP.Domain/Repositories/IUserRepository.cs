using ProjectP.Domain.Entities;

namespace ProjectP.Domain.Repositories;

public interface IUserRepository
{
    Task<bool> IsEmailUniqueAsync(string email);
    Task<User?> GetUserById(int id);
    Task<User?> GetUserByEmail(string email);
    Task<User?> GetUserByUserName(string userName);
    void Insert(User user);
}

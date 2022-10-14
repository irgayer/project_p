using ProjectP.Domain.Entities;

namespace ProjectP.Domain.Repositories;

public interface ISubscriptionRepository
{
    Task<bool> CheckIfSubscribedAsync(User user, User friend);
    void Insert(Subscription subscription);
    void Remove(Subscription subscription);
}

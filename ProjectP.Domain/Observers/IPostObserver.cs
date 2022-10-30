using ProjectP.Domain.Entities;

namespace ProjectP.Domain.Observers;

public interface IPostObserver
{
    void Update(Post post);
}

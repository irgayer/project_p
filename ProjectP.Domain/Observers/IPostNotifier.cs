using ProjectP.Domain.Entities;

namespace ProjectP.Domain.Observers;

public interface IPostNotifier
{
    void Attach(IPostObserver observer);
    void Detach(IPostObserver observer);
    void Notify(Post post);
}

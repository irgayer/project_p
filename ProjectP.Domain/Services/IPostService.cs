using ProjectP.Domain.Entities;
using ProjectP.Domain.Observers;

namespace ProjectP.Domain.Services;

public interface IPostService : IPostNotifier
{
    void UpdatePost(Post post);
}

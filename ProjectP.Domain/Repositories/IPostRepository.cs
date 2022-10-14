using ProjectP.Domain.Entities;

namespace ProjectP.Domain.Repositories;

public interface IPostRepository
{
    void Remove(Post post);
    void Insert(Post post);
    void Update(Post post);
}

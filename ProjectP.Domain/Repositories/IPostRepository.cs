using ProjectP.Domain.Entities;

namespace ProjectP.Domain.Repositories;

public interface IPostRepository
{
    List<Post> GetAll();
    Task<Post?> GetById(int id);
    void Remove(Post post);
    void Insert(Post post);
    void Update(Post post);
}

using ProjectP.Domain.Entities;

namespace ProjectP.WebAPI.DTO.Posts;

public class PostAdapter
{
    private static PostAdapter singleton;

    public static PostAdapter Singleton
    {
        get
        {
            if (singleton == null)
            {
                singleton = new PostAdapter();
            }
            return singleton;
        }
    }

    public PostDTO Adapt(Post post)
    {
        return new PostDTO
        {
            Id = post.Id,
            UserId = post.UserId,
            Content = post.Content
        };
    }
}

using ProjectP.Domain.Entities;

namespace ProjectP.Application.COR;

public class PostHasSlursHandler : HandlerBase
{
    public override bool Handle(Post post)
    {
        if (post.Content.Contains("shit"))
        {
            return false;
        }
        if (NextHandler != null)
        {
            return NextHandler.Handle(post);
        }

        return true;
    }
}

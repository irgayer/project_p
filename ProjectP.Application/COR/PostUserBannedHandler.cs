using ProjectP.Domain.Entities;

namespace ProjectP.Application.COR;

public class PostUserBannedHandler : HandlerBase
{
    public override bool Handle(Post post)
    {
        if (post.UserId == 0)
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

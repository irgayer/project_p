using ProjectP.Domain.Entities;

namespace ProjectP.Application.COR;

public abstract class HandlerBase : IHandler
{
    protected IHandler NextHandler;

    public abstract bool Handle(Post post);

    public void SetNextHandler(IHandler next)
    {
        NextHandler = next;
    }
}

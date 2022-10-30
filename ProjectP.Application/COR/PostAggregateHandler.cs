using ProjectP.Domain.Entities;

namespace ProjectP.Application.COR;

public class PostAggregateHandler : HandlerBase
{
    private readonly List<IHandler> handlers;

    public PostAggregateHandler(List<IHandler> handlers)
    {
        this.handlers = handlers;
    }

    public override bool Handle(Post post)
    {
        for (var handlerIndex = 0; handlerIndex < handlers.Count - 1; handlerIndex++)
        {
            handlers[handlerIndex].SetNextHandler(handlers[handlerIndex + 1]);
        }

        return handlers[0].Handle(post);
    }
}

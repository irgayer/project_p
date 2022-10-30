using ProjectP.Domain.Entities;
using ProjectP.Domain.Observers;
using ProjectP.Domain.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.Infrastructure.Services;

public class PostService : IPostService
{
    public List<IPostObserver> observers = new();

    public void UpdatePost(Post post)
    {
        Notify(post);
    }

    public void Attach(IPostObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IPostObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(Post post)
    {
        foreach (var observer in observers)
        {
            observer.Update(post);
        }
    }
}

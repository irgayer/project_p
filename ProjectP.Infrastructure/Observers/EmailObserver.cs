using ProjectP.Domain.Entities;
using ProjectP.Domain.Observers;

using System.Diagnostics;

namespace ProjectP.Infrastructure.Observers;

public class EmailObserver : IPostObserver
{
    public void Update(Post post)
    {
        Debug.WriteLine("Email observer to post!");
    }
}

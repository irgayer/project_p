using MediatR;
using Microsoft.EntityFrameworkCore;

using ProjectP.Application.Core.Abstractions.Common;
using ProjectP.Application.Core.Abstractions.Data;
using ProjectP.Domain.Entities;
using ProjectP.Domain.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.Infrastructure.Persistence.Repositories;

public class PostRepository : IPostRepository
{
    //private readonly IDateTimeProvider _dateTimeProvider;
    //private readonly IMediator _mediator;
    private ApplicationDbContext dbContext;

    public PostRepository(ApplicationDbContext dbContext)
        : base()
    {
        this.dbContext = dbContext;
        //_dateTimeProvider = dateTimeProvider;
        //_mediator = mediator;
    }

    public List<Post> GetAll()
    {
        return dbContext.Set<Post>().ToList();
    }

    public async Task<Post> GetById(int id)
    {
        return await dbContext.Posts.FirstOrDefaultAsync(post => post.Id == id);
    }

    public void Insert(Post post)
    {
        post.CreatedAt = post.UpdatedAt = DateTime.Now;
        dbContext.Posts.Add(post);
        dbContext.SaveChanges();
    }

    public void Remove(Post post)
    {
        dbContext.Posts.Remove(post);
        dbContext.SaveChanges();
    }

    public void Update(Post post)
    {
        throw new NotImplementedException();
    }
}

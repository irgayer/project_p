using MediatR;
using Microsoft.EntityFrameworkCore;

using ProjectP.Application.Core.Abstractions.Common;
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
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IMediator _mediator;

    public PostRepository(DbContextOptions options, IDateTimeProvider dateTimeProvider, IMediator mediator)
        : base()
    {
        _dateTimeProvider = dateTimeProvider;
        _mediator = mediator;
    }
    public void Insert(Post post)
    {
        throw new NotImplementedException();
    }

    public void Remove(Post post)
    {
        throw new NotImplementedException();
    }

    public void Update(Post post)
    {
        throw new NotImplementedException();
    }
}

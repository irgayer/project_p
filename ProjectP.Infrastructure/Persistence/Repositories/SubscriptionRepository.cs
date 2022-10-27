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

public class SubscriptionRepository : ISubscriptionRepository
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IMediator _mediator;

    public SubscriptionRepository(DbContextOptions options, IDateTimeProvider dateTimeProvider, IMediator mediator)
        : base()
    {
        _dateTimeProvider = dateTimeProvider;
        _mediator = mediator;
    }

    public Task<bool> CheckIfSubscribedAsync(User user, User friend)
    {
        throw new NotImplementedException();
    }

    public void Insert(Subscription subscription)
    {
        throw new NotImplementedException();
    }

    public void Remove(Subscription subscription)
    {
        throw new NotImplementedException();
    }
}

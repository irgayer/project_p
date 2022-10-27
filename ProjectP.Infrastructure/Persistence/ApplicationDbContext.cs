using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using ProjectP.Application.Core.Abstractions.Common;
using ProjectP.Application.Core.Abstractions.Data;
using ProjectP.Domain.Primitives;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IDbContext, IUnitOfWork
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly IMediator _mediator;

    public ApplicationDbContext(DbContextOptions options, IDateTimeProvider dateTimeProvider, IMediator mediator)
        : base()
    {
        _dateTimeProvider = dateTimeProvider;
        _mediator = mediator;
    }

    public new DbSet<TEntity> Set<TEntity>()
            where TEntity : Entity
            => base.Set<TEntity>();

    public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> GetBydIdAsync<TEntity>(int id) where TEntity : Entity
    {
        throw new NotImplementedException();
    }

    public void Insert<TEntity>(TEntity entity) where TEntity : Entity
    {
        throw new NotImplementedException();
    }

    public void InsertRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : Entity
    {
        throw new NotImplementedException();
    }

    void IDbContext.Remove<TEntity>(TEntity entity)
    {
        throw new NotImplementedException();
    }
}

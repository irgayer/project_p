using Microsoft.EntityFrameworkCore;

using ProjectP.Domain.Primitives;

using System.Collections.Generic;

namespace ProjectP.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
    Task<TEntity?> GetBydIdAsync<TEntity>(int id) where TEntity : Entity;
    void Insert<TEntity>(TEntity entity) where TEntity : Entity;
    void InsertRange<TEntity>(IReadOnlyCollection<TEntity> entities) where TEntity : Entity;
    void Remove<TEntity>(TEntity entity) where TEntity : Entity;
    void SaveChanges();
}

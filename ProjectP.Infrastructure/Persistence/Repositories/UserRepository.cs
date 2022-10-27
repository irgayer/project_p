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

public class UserRepository : IUserRepository
{
    private readonly IDbContext _dbContext;
    private readonly IDateTimeProvider _dateTimeProvider;

    public UserRepository(IDbContext dbContext, IDateTimeProvider dateTimeProvider)
    {
        _dbContext = dbContext;
        _dateTimeProvider = dateTimeProvider;
    }

    public Task<User?> GetUserByEmail(string email)
    {
        return _dbContext.Set<User>().Where(x => x.Email == email).SingleOrDefaultAsync();
    }

    public Task<User?> GetUserById(int id)
    {
        return _dbContext.Set<User>().Where(x => x.Id == id).SingleOrDefaultAsync();
    }

    public Task<User?> GetUserByUserName(string userName)
    {
        return _dbContext.Set<User>().Where(x => x.UserName == userName).SingleOrDefaultAsync();
    }

    public void Insert(User user)
    {
        _dbContext.Insert<User>(user);
    }

    public Task<bool> IsEmailUniqueAsync(string email)
    {
        return _dbContext.Set<User>().AnyAsync(x => x.Email == email);
    }
}

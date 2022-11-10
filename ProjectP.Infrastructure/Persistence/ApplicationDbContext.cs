using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using ProjectP.Application.Core.Abstractions.Common;
using ProjectP.Application.Core.Abstractions.Data;
using ProjectP.Domain.Entities;
using ProjectP.Domain.Primitives;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectP.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    //private readonly IDateTimeProvider _dateTimeProvider;
    //private readonly IMediator _mediator;

    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Biography> Biographies { get; set; }
 
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
        //_dateTimeProvider = dateTimeProvider;
        //_mediator = mediator;
    }
}

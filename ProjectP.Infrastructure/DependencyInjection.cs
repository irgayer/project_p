﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ProjectP.Application.Core.Abstractions.Data;
using ProjectP.Domain.Repositories;
using ProjectP.Infrastructure.Persistence.Repositories;
using ProjectP.Infrastructure.Persistence;
using ProjectP.Domain.Services;
using ProjectP.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace ProjectP.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<IDbContext>(serviceProvider => serviceProvider.GetRequiredService<ApplicationDbContext>());
        //services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<IPostRepository>(serviceProvider => serviceProvider.GetRequiredService<PostRepository>());
        services.AddScoped<IUserRepository>(serviceProvider => serviceProvider.GetRequiredService<UserRepository>());
        services.AddScoped<ISubscriptionRepository>(serviceProvider => serviceProvider.GetRequiredService<SubscriptionRepository>());

        services.AddSingleton<IPostService, PostService>();

        return services;
    }
}

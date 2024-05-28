using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Services;
using FlavorVerse.Application.Identity.Abstractions;
using FlavorVerse.Application.Identity.Services;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using FlavorVerse.Domain.Abstractions;
using FlavorVerse.Infrastructure.Logger;

namespace FlavorVerse.DependencyInjection;

public static partial class Extensions
{
    public static IServiceCollection AllApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        PersistenceServices(services);
        ApplicationServices(services);
        ApplicationIdentityServices(services, configuration);
        InfrastructureServices(services);

        return services;
    }

    private static IServiceCollection ApplicationIdentityServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["Jwt:Issuer"],
                ValidAudience = configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey
                (Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!)),
                ClockSkew = TimeSpan.Zero
            };
        });

        services.AddAuthorization(options =>
        {
            options.AddPolicy(Constants.ADMIN, policy => policy.RequireRole(
                eUserRole.Admin.ToString()));
            options.AddPolicy(Constants.MEMBER, policy => policy.RequireRole(
                eUserRole.Member.ToString()));
        });

        services.AddScoped<IJwtService, AuthenticationService>();

        return services;
    }

    private static IServiceCollection ApplicationServices(IServiceCollection services)
    {
        var assembly = typeof(Application.Abstractions.Messaging.BaseHandler).Assembly;

        services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));
        services.AddValidatorsFromAssembly(assembly);
        services.AddAutoMapper(assembly);

        services.AddScoped<ITransactionService, TransactionService>();

        return services;
    }

    private static IServiceCollection PersistenceServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(
            opt => opt.UseSqlServer("Data Source=localhost;Initial Catalog=FlavorVerse;TrustServerCertificate=True;Integrated security=True;"));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }

    private static IServiceCollection InfrastructureServices(IServiceCollection services)
    {
        services.AddTransient<IExceptionLogger, DbExceptionLogger>();

        return services;
    }
}
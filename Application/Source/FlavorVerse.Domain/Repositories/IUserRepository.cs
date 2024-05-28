using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface IUserRepository
{
    Task AddAsync(User user, UserRole role, CancellationToken cancellationToken = default);

    Task<bool> UserExistByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task<User?> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task<bool> UserExistByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<User?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<User?> GetDeletedUserByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<PaginatedList<User>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default);
}
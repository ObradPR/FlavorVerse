using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Entities.Application_lu;

namespace FlavorVerse.Domain.Repositories;

public interface IRoleRepository
{
    Task<bool> RolesExistAsync(IEnumerable<string> roles, CancellationToken cancellationToken = default);

    Task<IEnumerable<UserRole>> GetUserRolesAsync(Guid id, CancellationToken cancellationToken = default);

    Task<IEnumerable<Role_lu>> GetAllAsync(CancellationToken cancellationToken = default);

    Task AddUserRoleAsync(UserRole userRole);
}
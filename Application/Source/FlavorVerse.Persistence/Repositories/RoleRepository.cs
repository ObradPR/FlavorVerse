using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class RoleRepository : BaseRepository, IRoleRepository
{
    public RoleRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<bool> RolesExistAsync(IEnumerable<string> roles, CancellationToken cancellationToken = default)
    {
        var checkRolesList = await Context.Roles_lu
            .Where(x => roles.Contains(x.Name))
            .Select(x => x.Name)
            .ToListAsync(cancellationToken);

        return checkRolesList.Count == roles.ToList().Count;
    }

    public async Task<IEnumerable<UserRole>> GetUserRolesAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.UserRoles
                .Include(x => x.Role)
                .Where(x => x.UserId.Equals(id))
                .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<Role_lu>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await Context.Roles_lu.ToListAsync(cancellationToken);
    }

    public async Task AddUserRoleAsync(UserRole userRole)
    {
        await Context.AddAsync(userRole);
    }
}
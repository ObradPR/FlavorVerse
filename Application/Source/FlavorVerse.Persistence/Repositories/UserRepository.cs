using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Extensions;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task AddAsync(User user, UserRole role, CancellationToken cancellationToken = default)
    {
        List<object> entities = [user, role];

        await Context.AddRangeAsync(entities, cancellationToken);
    }

    public async Task<bool> UserExistByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Email.Equals(email), cancellationToken) is not null;
    }

    public async Task<User?> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await Context.Users
            .Include(x => x.UserRoles)
            .ThenInclude(x => x.Role)
            .FirstOrDefaultAsync(x => x.Email.Equals(email) && x.IsActive, cancellationToken);
    }

    public async Task<bool> UserExistByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken) is not null;
    }

    public async Task<User?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Id.Equals(id) && x.IsActive, cancellationToken);
    }

    public async Task<User?> GetDeletedUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Id.Equals(id) && !x.IsActive, cancellationToken);
    }

    public async Task<PaginatedList<User>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Users.AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.SearchTerm))
        {
            query = query.Where(x => x.DisplayName.ToLower().Contains(queryParams.SearchTerm));
        }

        if (!string.IsNullOrEmpty(queryParams.FilterCriteria) && !string.IsNullOrEmpty(queryParams.FilterDirection))
        {
            query = queryParams.FilterDirection.ToLower().Equals("asc") ?
                query.OrderByDynamic(queryParams.FilterCriteria) :
                query.OrderByDescendingDynamic(queryParams.FilterCriteria);
        }

        var totalRecords = await query.CountAsync(cancellationToken);

        var users = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .ToListAsync(cancellationToken);

        return new PaginatedList<User>
        {
            Items = users,
            TotalCount = totalRecords,
        };
    }
}
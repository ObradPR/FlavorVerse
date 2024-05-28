using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class AuditRepository : BaseRepository, IAuditRepository
{
    public AuditRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task AddAsync(Audit audit, CancellationToken cancellationToken = default)
    {
        await Context.AddAsync(audit, cancellationToken);
    }

    public async Task<PaginatedList<Audit>> GetAllAsync(AuditQueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Audits
            .Include(x => x.User)
            .Include(x => x.EntityType)
            .Include(x => x.ActionType)
            .AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.UserFullName))
        {
            query = query.Where(x => x.User.DisplayName.ToLower().Contains(queryParams.UserFullName));
        }

        if (!string.IsNullOrEmpty(queryParams.ActionName))
        {
            query = query.Where(x => x.ActionType.Name.ToLower().Contains(queryParams.ActionName));
        }

        if (queryParams.DateFrom.HasValue && queryParams.DateTo.HasValue)
        {
            query = query.Where(x => x.RecordDate >= queryParams.DateFrom.Value && x.RecordDate <= queryParams.DateTo.Value);
        }
        else if (queryParams.DateFrom.HasValue)
        {
            query = query.Where(x => x.RecordDate >= queryParams.DateFrom.Value);
        }
        else if (queryParams.DateTo.HasValue)
        {
            query = query.Where(x => x.RecordDate <= queryParams.DateTo.Value);
        }

        var totalRecords = await query.CountAsync(cancellationToken);

        var audits = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Audit>
        {
            Items = audits,
            TotalCount = totalRecords,
        };
    }
}
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface IAuditRepository
{
    Task AddAsync(Audit audit, CancellationToken cancellationToken = default);

    Task<PaginatedList<Audit>> GetAllAsync(AuditQueryParams queryParams, CancellationToken cancellationToken = default);
}
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using System.Threading;

namespace FlavorVerse.Domain.Repositories;

public interface IRatingRepository
{
    Task<PaginatedList<Rating>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default);

    Task<PaginatedList<Rating>> GetAllByUserIdAsync(Guid id, QueryParams queryParams, CancellationToken cancellationToken = default);

    Task<PaginatedList<Rating>> GetAllByRecipeIdAsync(Guid id, QueryParams queryParams, CancellationToken cancellationToken = default);

    Task<Rating?> GetRatingByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddAsync(Rating rating, CancellationToken cancellationToken = default);
}
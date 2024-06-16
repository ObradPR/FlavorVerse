using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface ICuisineRepository
{
    Task<PaginatedList<Cuisine>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default);

    Task<bool> CuisineExistByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> CuisineExistByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<int> GetNewCuisineIdAsync();

    Task AddAsync(Cuisine cuisine, CancellationToken cancellationToken);

    Task<Cuisine?> GetCuisineByIdAsync(int id, CancellationToken cancellationToken);
}
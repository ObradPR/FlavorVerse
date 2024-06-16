using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface ICategoryRepository
{
    Task<Category?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken);

    Task<bool> CategoryExistByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<bool> CategoryExistByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<PaginatedList<Category>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default);

    Task AddAsync(Category category, CancellationToken cancellationToken = default);

    Task<int> GetNewCategoryIdAsync();
}
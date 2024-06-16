using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface IIngredientRepoistory
{
    Task<bool> IngredientExistByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> IngredientExistByIdAsync(int id, CancellationToken cancellationToken = default);

    Task<PaginatedList<Ingredient>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default);

    Task AddAsync(Ingredient ingredient, CancellationToken cancellationToken);

    Task<int> GetNewIngredientIdAsync();

    Task<Ingredient?> GetIngredientByIdAsync(int id, CancellationToken cancellationToken);
}
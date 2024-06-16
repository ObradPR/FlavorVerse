using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Extensions;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class IngredientRepository : BaseRepository, IIngredientRepoistory
{
    public IngredientRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<bool> IngredientExistByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await Context.Ingredients.FirstOrDefaultAsync(x => x.Name.Equals(name), cancellationToken) is not null;
    }

    public async Task<int> GetNewIngredientIdAsync()
    {
        return await Context.Ingredients.MaxAsync(x => x.Id) + 1;
    }

    public async Task AddAsync(Ingredient ingredient, CancellationToken cancellationToken)
    {
        await Context.Ingredients.AddAsync(ingredient, cancellationToken);
    }

    public async Task<PaginatedList<Ingredient>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Ingredients.AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.SearchTerm))
        {
            query = query.Where(x => x.Name.ToLower().Contains(queryParams.SearchTerm));
        }

        if (!string.IsNullOrEmpty(queryParams.FilterCriteria) && !string.IsNullOrEmpty(queryParams.FilterDirection))
        {
            query = queryParams.FilterDirection.ToLower().Equals("asc") ?
                query.OrderByDynamic(queryParams.FilterCriteria) :
                query.OrderByDescendingDynamic(queryParams.FilterCriteria);
        }

        var totalRecords = await query.CountAsync(cancellationToken);

        var ingredients = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .Where(x => x.IsActive)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Ingredient>
        {
            Items = ingredients,
            TotalCount = totalRecords,
        };
    }

    public async Task<Ingredient?> GetIngredientByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await Context.Ingredients.FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken);
    }

    public async Task<bool> IngredientExistByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Context.Ingredients.FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken) is not null;
    }
}
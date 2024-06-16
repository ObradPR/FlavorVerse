using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Extensions;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class CategoryRepository : BaseRepository, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Category?> GetCategoryByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await Context.Categories.FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken);
    }

    public async Task<bool> CategoryExistByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await Context.Categories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken) is not null;
    }

    public async Task<bool> CategoryExistByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await Context.Categories.FirstOrDefaultAsync(x => x.Name.Equals(name), cancellationToken) is not null;
    }

    public async Task<PaginatedList<Category>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Categories.AsQueryable();

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

        var categories = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .Where(x => x.IsActive)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Category>
        {
            Items = categories,
            TotalCount = totalRecords,
        };
    }

    public async Task AddAsync(Category category, CancellationToken cancellationToken = default)
    {
        await Context.Categories.AddAsync(category, cancellationToken);
    }

    public async Task<int> GetNewCategoryIdAsync()
    {
        return await Context.Categories.MaxAsync(x => x.Id) + 1;
    }
}
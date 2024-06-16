using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Extensions;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class CuisineRepository : BaseRepository, ICuisineRepository
{
    public CuisineRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task AddAsync(Cuisine cuisine, CancellationToken cancellationToken)
    {
        await Context.Cuisines.AddAsync(cuisine, cancellationToken);
    }

    public async Task<bool> CuisineExistByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Context.Cuisines.FirstOrDefaultAsync(x => x.Id == id, cancellationToken) is not null;
    }

    public async Task<bool> CuisineExistByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await Context.Cuisines.FirstOrDefaultAsync(x => x.Name.Equals(name), cancellationToken) is not null;
    }

    public async Task<PaginatedList<Cuisine>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Cuisines.AsQueryable();

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

        var cuisines = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .Where(x => x.IsActive)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Cuisine>
        {
            Items = cuisines,
            TotalCount = totalRecords,
        };
    }

    public async Task<Cuisine?> GetCuisineByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await Context.Cuisines.FirstOrDefaultAsync(x => x.Id == id && x.IsActive, cancellationToken);
    }

    public async Task<int> GetNewCuisineIdAsync()
    {
        return await Context.Cuisines.MaxAsync(x => x.Id) + 1;
    }
}
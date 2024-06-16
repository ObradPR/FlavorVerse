using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Extensions;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class RatingRepository : BaseRepository, IRatingRepository
{
    public RatingRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<PaginatedList<Rating>> GetAllAsync(QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Ratings
            .Include(x => x.User)
            .Where(x => x.IsActive)
            .AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.SearchTerm))
        {
            query = query.Where(x => x.Comment.ToLower().Contains(queryParams.SearchTerm));
        }

        if (!string.IsNullOrEmpty(queryParams.FilterCriteria) && !string.IsNullOrEmpty(queryParams.FilterDirection))
        {
            query = queryParams.FilterDirection.ToLower().Equals("asc") ?
                query.OrderByDynamic(queryParams.FilterCriteria) :
                query.OrderByDescendingDynamic(queryParams.FilterCriteria);
        }

        var totalRecords = await query.CountAsync(cancellationToken);

        var ratings = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Rating>
        {
            Items = ratings,
            TotalCount = totalRecords,
        };
    }

    public async Task<PaginatedList<Rating>> GetAllByUserIdAsync(Guid id, QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Ratings
            .Include(x => x.User)
            .Where(x => x.IsActive && x.User.Id.Equals(id))
            .AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.SearchTerm))
        {
            query = query.Where(x => x.Comment.ToLower().Contains(queryParams.SearchTerm));
        }

        if (!string.IsNullOrEmpty(queryParams.FilterCriteria) && !string.IsNullOrEmpty(queryParams.FilterDirection))
        {
            query = queryParams.FilterDirection.ToLower().Equals("asc") ?
                query.OrderByDynamic(queryParams.FilterCriteria) :
                query.OrderByDescendingDynamic(queryParams.FilterCriteria);
        }

        var totalRecords = await query.CountAsync(cancellationToken);

        var ratings = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Rating>
        {
            Items = ratings,
            TotalCount = totalRecords,
        };
    }

    public async Task<PaginatedList<Rating>> GetAllByRecipeIdAsync(Guid id, QueryParams queryParams, CancellationToken cancellationToken = default)
    {
        var query = Context.Ratings
            .Include(x => x.Recipe)
            .Include(x => x.User)
            .Where(x => x.IsActive && x.Recipe.Id.Equals(id))
            .AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.SearchTerm))
        {
            query = query.Where(x => x.Comment.ToLower().Contains(queryParams.SearchTerm));
        }

        if (!string.IsNullOrEmpty(queryParams.FilterCriteria) && !string.IsNullOrEmpty(queryParams.FilterDirection))
        {
            query = queryParams.FilterDirection.ToLower().Equals("asc") ?
                query.OrderByDynamic(queryParams.FilterCriteria) :
                query.OrderByDescendingDynamic(queryParams.FilterCriteria);
        }

        var totalRecords = await query.CountAsync(cancellationToken);

        var ratings = await query
            .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
            .Take(queryParams.PageSize)
            .ToListAsync(cancellationToken);

        return new PaginatedList<Rating>
        {
            Items = ratings,
            TotalCount = totalRecords,
        };
    }

    public async Task<Rating?> GetRatingByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Ratings.FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
    }

    public async Task AddAsync(Rating rating, CancellationToken cancellationToken = default)
    {
        await Context.Ratings.AddAsync(rating, cancellationToken);
    }
}
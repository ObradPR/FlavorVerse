using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class DietaryRepository : BaseRepository, IDietaryInfoRepository
{
    public DietaryRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<DietaryInfo?> GetDietaryInfoByStatsAsync(bool glutenFree, bool dairyFree, bool vegetarian, bool vegan, CancellationToken cancellationToken = default)
    {
        return await Context.DietaryInfos
            .FirstOrDefaultAsync(x =>
                x.GlutenFree == glutenFree &&
                x.DairyFree == dairyFree &&
                x.Vegetarian == vegetarian &&
                x.Vegan == vegan, cancellationToken);
    }
}
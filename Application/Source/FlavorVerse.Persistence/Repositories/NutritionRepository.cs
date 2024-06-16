using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class NutritionRepository : BaseRepository, INutritionRepository
{
    public NutritionRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Nutrition?> GetNutritionByRecipeIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var recipe = await Context.Recipes.FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);

        if (recipe is null)
        {
            return null;
        }

        return await Context.Nutritions.FirstOrDefaultAsync(x => x.Id.Equals(recipe.NutritionId) && x.IsActive, cancellationToken);
    }

    public async Task<Nutrition?> GetNutritionByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await Context.Nutritions
            .Include(x => x.Recipes)
            .FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
    }
}
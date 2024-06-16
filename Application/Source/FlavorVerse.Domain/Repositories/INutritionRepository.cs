using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface INutritionRepository
{
    Task<Nutrition?> GetNutritionByRecipeIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Nutrition?> GetNutritionByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
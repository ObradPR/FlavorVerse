using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface IDietaryInfoRepository
{
    Task<DietaryInfo?> GetDietaryInfoByStatsAsync(bool glutenFree, bool dairyFree, bool vegetarian, bool vegan, CancellationToken cancellationToken = default);
}
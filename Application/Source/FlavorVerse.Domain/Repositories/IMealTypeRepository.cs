using FlavorVerse.Domain.Entities.Application_lu;

namespace FlavorVerse.Domain.Repositories;

public interface IMealTypeRepository
{
    Task<bool> MealTypeExistByIdAsync(int id, CancellationToken cancellationToken = default);
}
namespace FlavorVerse.Domain.Repositories;

public interface IDifficultyCookingRepository
{
    Task<bool> DifficultyCookingExistByIdAsync(int id, CancellationToken cancellationToken = default);
}
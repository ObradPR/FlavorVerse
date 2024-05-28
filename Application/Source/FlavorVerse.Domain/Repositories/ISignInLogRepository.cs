using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface ISignInLogRepository
{
    Task AddAsync(SignInLog log, CancellationToken cancellationToken = default);
}
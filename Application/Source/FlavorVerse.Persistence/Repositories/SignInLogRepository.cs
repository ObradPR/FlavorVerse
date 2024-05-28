using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;

namespace FlavorVerse.Persistence.Repositories;

public class SignInLogRepository : BaseRepository, ISignInLogRepository
{
    public SignInLogRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task AddAsync(SignInLog log, CancellationToken cancellationToken = default)
    {
        await Context.AddAsync(log, cancellationToken);
    }
}
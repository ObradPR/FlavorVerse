using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;

namespace FlavorVerse.Persistence.Repositories;

public class ErrorLogRepository : BaseRepository, IErrorLogRepository
{
    public ErrorLogRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task AddAsync(ErrorLog log)
    {
        await Context.ErrorLogs.AddAsync(log);
    }
}
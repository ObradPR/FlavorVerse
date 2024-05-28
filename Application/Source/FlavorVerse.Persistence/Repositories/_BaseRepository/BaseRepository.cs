using FlavorVerse.Persistence.Contexts;

namespace FlavorVerse.Persistence.Repositories._BaseRepository;

public abstract class BaseRepository
{
    protected ApplicationDbContext Context { get; set; }

    protected BaseRepository(ApplicationDbContext context)
    {
        Context = context;
    }
}
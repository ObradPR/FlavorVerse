using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class DifficultyCookingRepository : BaseRepository, IDifficultyCookingRepository
{
    public DifficultyCookingRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<bool> DifficultyCookingExistByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Context.DifficultyCookings_lu.FirstOrDefaultAsync(x => x.Id == id, cancellationToken) is not null;
    }
}
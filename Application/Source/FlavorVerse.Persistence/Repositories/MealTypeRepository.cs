using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Repositories;

public class MealTypeRepository : BaseRepository, IMealTypeRepository
{
    public MealTypeRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<bool> MealTypeExistByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Context.MealTypes_lu.FirstOrDefaultAsync(x => x.Id == id, cancellationToken) is not null;
    }
}
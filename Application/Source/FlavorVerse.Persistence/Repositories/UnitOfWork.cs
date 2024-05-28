using FlavorVerse.Domain.Repositories;
using FlavorVerse.Persistence.Contexts;
using FlavorVerse.Persistence.Repositories._BaseRepository;

namespace FlavorVerse.Persistence.Repositories
{
    public class UnitOfWork : BaseRepository, IUnitOfWork
    {
        public UnitOfWork(ApplicationDbContext context) : base(context)
        {
        }

        // Properties

        public IUserRepository UserRepository => new UserRepository(Context);
        public ISignInLogRepository SignInLogRepository => new SignInLogRepository(Context);
        public IAuditRepository AuditRepository => new AuditRepository(Context);
        public IErrorLogRepository ErrorLogRepository => new ErrorLogRepository(Context);
        public IRoleRepository RoleRepository => new RoleRepository(Context);

        public async Task<bool> Complete() => await Context.SaveChangesAsync() > 0;

        public bool HasChanges() => Context.ChangeTracker.HasChanges();
    }
}
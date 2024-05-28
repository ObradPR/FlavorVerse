namespace FlavorVerse.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ISignInLogRepository SignInLogRepository { get; }
        IAuditRepository AuditRepository { get; }
        IErrorLogRepository ErrorLogRepository { get; }
        IRoleRepository RoleRepository { get; }

        Task<bool> Complete();

        bool HasChanges();
    }
}
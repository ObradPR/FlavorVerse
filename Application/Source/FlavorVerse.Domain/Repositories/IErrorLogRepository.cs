using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Repositories;

public interface IErrorLogRepository
{
    Task AddAsync(ErrorLog log);
}
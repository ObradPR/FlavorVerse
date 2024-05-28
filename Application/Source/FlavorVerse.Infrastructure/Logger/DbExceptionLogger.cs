using FlavorVerse.Domain.Abstractions;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Infrastructure.Logger;

public class DbExceptionLogger : IExceptionLogger
{
    private readonly IUnitOfWork _unitOfWork;

    public DbExceptionLogger(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

    public Guid LogException(Exception ex)
    {
        var id = Guid.NewGuid();

        var log = new ErrorLog
        {
            Id = id,
            Message = ex.Message,
            StackTrace = ex.StackTrace,
            RecordDate = DateTime.UtcNow
        };

        _unitOfWork.ErrorLogRepository.AddAsync(log);

        _unitOfWork.Complete();

        return id;
    }
}
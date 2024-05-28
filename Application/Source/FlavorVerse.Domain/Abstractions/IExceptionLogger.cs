namespace FlavorVerse.Domain.Abstractions;

public interface IExceptionLogger
{
    Guid LogException(Exception ex);
}
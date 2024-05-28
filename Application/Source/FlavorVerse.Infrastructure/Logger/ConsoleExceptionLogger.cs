using FlavorVerse.Domain.Abstractions;
using Serilog;

namespace FlavorVerse.Infrastructure.Logger;

public class ConsoleExceptionLogger : IExceptionLogger
{
    public Guid LogException(Exception ex)
    {
        var id = Guid.NewGuid();
        Log.Error(ex, $"An Error occurred\nID: {id}\n {ex.Message}");

        return id;
    }
}
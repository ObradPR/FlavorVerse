namespace FlavorVerse.Domain.Entities.Application;

public class ErrorLog
{
    public Guid Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public string? StackTrace { get; set; }
    public DateTime RecordDate { get; set; }
}
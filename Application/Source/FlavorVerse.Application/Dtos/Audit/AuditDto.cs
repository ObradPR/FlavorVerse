namespace FlavorVerse.Application.Dtos.Audit;

public class AuditDto : BaseDto
{
    public Guid Id { get; set; }
    public Guid EntityId { get; set; }
    public Guid TransactionId { get; set; }
    public string EntityType { get; set; } = string.Empty;
    public string ActionType { get; set; } = string.Empty;
    public bool IsSuccess { get; set; }
    public string DetailsJson { get; set; } = string.Empty;
    public DateTime RecordDate { get; set; }
    public Guid ExecutedById { get; set; }
    public string ExecutedBy { get; set; } = string.Empty;
    public long ExecutionTimeInMs { get; set; }
}
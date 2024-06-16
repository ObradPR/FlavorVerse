using FlavorVerse.Domain.Entities.Application_lu;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class Audit
{
    public Guid Id { get; set; }
    public string EntityId { get; set; } = string.Empty;
    public Guid TransactionId { get; set; }
    public int EntityTypeId { get; set; }
    public int ActionTypeId { get; set; }
    public bool IsSuccess { get; set; }
    public string? DetailsJson { get; set; }
    public DateTime RecordDate { get; set; }
    public Guid ExecutedById { get; set; }
    public long ExecutionTimeInMs { get; set; }

    // Relationships

    [ForeignKey(nameof(EntityTypeId))]
    public virtual EntityType_lu EntityType { get; set; }

    [ForeignKey(nameof(ActionTypeId))]
    public virtual ActionType_lu ActionType { get; set; }

    [ForeignKey(nameof(ExecutedById))]
    public virtual User User { get; set; }
}
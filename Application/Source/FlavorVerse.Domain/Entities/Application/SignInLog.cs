using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class SignInLog
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime RecordDate { get; set; }

    // Relationships

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }
}
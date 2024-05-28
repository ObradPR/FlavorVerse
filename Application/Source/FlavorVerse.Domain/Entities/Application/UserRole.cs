using FlavorVerse.Domain.Entities.Application_lu;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class UserRole
{
    public Guid UserId { get; set; }
    public int RoleId { get; set; }

    // Relationships

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }

    [ForeignKey(nameof(RoleId))]
    public virtual Role_lu Role { get; set; }
}
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities._BaseEntities;

namespace FlavorVerse.Domain.Entities.Application;

public class User : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateOnly? DateOfBirth { get; set; }

    // Relationships

    public virtual ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    public virtual ICollection<SignInLog> SignInLogs { get; set; } = new HashSet<SignInLog>();
    public virtual ICollection<Audit> Audits { get; set; } = new HashSet<Audit>();
}
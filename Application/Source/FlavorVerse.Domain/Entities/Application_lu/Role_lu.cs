using FlavorVerse.Domain.Entities._BaseEntities;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Entities.Application_lu
{
    public class Role_lu : Entity_lu
    {
        // Relationships
        public virtual ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
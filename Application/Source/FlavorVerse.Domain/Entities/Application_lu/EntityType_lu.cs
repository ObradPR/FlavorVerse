using FlavorVerse.Domain.Entities._BaseEntities;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Entities.Application_lu
{
    public class EntityType_lu : Entity_lu
    {
        // Relationships
        public virtual ICollection<Audit> Audits { get; set; } = new HashSet<Audit>();
    }
}
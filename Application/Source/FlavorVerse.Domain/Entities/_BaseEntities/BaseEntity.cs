namespace FlavorVerse.Domain.Entities._BaseEntities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
}
using FlavorVerse.Domain.Entities._BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class Rating : Entity
{
    public Guid UserId { get; set; }
    public int RatingValue { get; set; }
    public string Comment { get; set; } = string.Empty;
    public Guid RecipeId { get; set; }

    // Relationships

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public virtual Recipe Recipe { get; set; }
}
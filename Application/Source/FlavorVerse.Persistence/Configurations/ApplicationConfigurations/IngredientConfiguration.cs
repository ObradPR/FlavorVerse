using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class IngredientConfiguration : BaseEntity_luConfiguration<Ingredient>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Ingredient> builder)
    {
        builder.HasData(
               new Ingredient { Id = 1, Name = "Flour" },
               new Ingredient { Id = 2, Name = "Sugar" },
               new Ingredient { Id = 3, Name = "Salt" },
               new Ingredient { Id = 4, Name = "Pepper" },
               new Ingredient { Id = 5, Name = "Olive Oil" },
               new Ingredient { Id = 6, Name = "Butter" },
               new Ingredient { Id = 7, Name = "Garlic" },
               new Ingredient { Id = 8, Name = "Onion" },
               new Ingredient { Id = 9, Name = "Tomato" },
               new Ingredient { Id = 10, Name = "Lemon Juice" },
               new Ingredient { Id = 11, Name = "Chicken Breast" },
               new Ingredient { Id = 12, Name = "Beef Steak" },
               new Ingredient { Id = 13, Name = "Salmon Fillet" },
               new Ingredient { Id = 14, Name = "Shrimp" },
               new Ingredient { Id = 15, Name = "Eggs" },
               new Ingredient { Id = 16, Name = "Milk" });
    }
}
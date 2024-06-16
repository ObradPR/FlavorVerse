using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class IngredientConfiguration : BaseEntity_luConfiguration<Ingredient>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Ingredient> builder)
    {
        builder.HasData(
               new Ingredient { Id = 1, Name = "Flour", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 2, Name = "Sugar", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 3, Name = "Salt", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 4, Name = "Pepper", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 5, Name = "Olive Oil", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 6, Name = "Butter", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 7, Name = "Garlic", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 8, Name = "Onion", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 9, Name = "Tomato", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 10, Name = "Lemon Juice", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 11, Name = "Chicken Breast", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 12, Name = "Beef Steak", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 13, Name = "Salmon Fillet", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 14, Name = "Shrimp", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 15, Name = "Eggs", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 16, Name = "Milk", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 17, Name = "Spaghetti", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 18, Name = "Parmesan Cheese", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 19, Name = "Pancetta", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 20, Name = "Black Pepper", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 21, Name = "Cucumber", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 22, Name = "Red Onion", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 23, Name = "Feta Cheese", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 24, Name = "Oregano", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 25, Name = "Black Olives", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 26, Name = "Romaine Lettuce", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 27, Name = "Caesar Dressing", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 28, Name = "Croutons", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 29, Name = "Bell Peppers", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 30, Name = "Broccoli", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 31, Name = "Carrot", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 32, Name = "Soy Sauce", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 33, Name = "Taco Seasoning", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 34, Name = "Tortillas", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 35, Name = "Lettuce", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 36, Name = "Cheddar Cheese", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 37, Name = "Sour Cream", IsActive = true, CreatedAt = DateTime.UtcNow },
               new Ingredient { Id = 38, Name = "Salsa", IsActive = true, CreatedAt = DateTime.UtcNow });
    }
}
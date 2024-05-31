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
               new Ingredient { Id = 16, Name = "Milk" },
               new Ingredient { Id = 17, Name = "Spaghetti" },
               new Ingredient { Id = 18, Name = "Parmesan Cheese" },
               new Ingredient { Id = 19, Name = "Pancetta" },
               new Ingredient { Id = 20, Name = "Black Pepper" },
               new Ingredient { Id = 21, Name = "Cucumber" },
               new Ingredient { Id = 22, Name = "Red Onion" },
               new Ingredient { Id = 23, Name = "Feta Cheese" },
               new Ingredient { Id = 24, Name = "Oregano" },
               new Ingredient { Id = 25, Name = "Black Olives" },
               new Ingredient { Id = 26, Name = "Romaine Lettuce" },
               new Ingredient { Id = 27, Name = "Caesar Dressing" },
               new Ingredient { Id = 28, Name = "Croutons" },
               new Ingredient { Id = 29, Name = "Bell Peppers" },
               new Ingredient { Id = 30, Name = "Broccoli" },
               new Ingredient { Id = 31, Name = "Carrot" },
               new Ingredient { Id = 32, Name = "Soy Sauce" },
               new Ingredient { Id = 33, Name = "Taco Seasoning" },
               new Ingredient { Id = 34, Name = "Tortillas" },
               new Ingredient { Id = 35, Name = "Lettuce" },
               new Ingredient { Id = 36, Name = "Cheddar Cheese" },
               new Ingredient { Id = 37, Name = "Sour Cream" },
               new Ingredient { Id = 38, Name = "Salsa" });
    }
}
using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;
using FlavorVerse.Common;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RecipeConfiguration : BaseEntityConfiguration<Recipe>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Recipe> builder)
    {
        builder.Property(x => x.Title)
            .HasMaxLength(100);

        builder.Property(x => x.Image)
            .HasMaxLength(255);

        builder.Property(x => x.Description)
            .HasMaxLength(500);

        builder.Property(x => x.CookingTime)
            .HasMaxLength(20);

        builder.Property(x => x.Featured)
            .HasDefaultValue(false);

        builder.Property(x => x.Instructions)
            .HasMaxLength(1000);

        // Relationships

        builder.HasOne(x => x.MealType_Lu)
            .WithMany(mt => mt.Recipes)
            .HasForeignKey(r => r.MealTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Nutrition)
            .WithMany(n => n.Recipes)
            .HasForeignKey(r => r.NutritionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.DietaryInfo)
            .WithMany(di => di.Recipes)
            .HasForeignKey(r => r.DietaryInfoId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.DifficultyCooking_Lu)
            .WithMany(dc => dc.Recipes)
            .HasForeignKey(r => r.DifficultyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(u => u.Recipes)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed data

        builder.HasData(
            new Recipe
            {
                Id = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                Title = "Spaghetti Carbonara",
                UserId = Guid.Parse(Constants.SYSTEM_USER_ID),
                Image = "https://example.com/images/spaghetti-carbonara.jpg",
                Description = "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.",
                CookingTime = "30 minutes",
                Servings = 4,
                DifficultyId = 2,
                DietaryInfoId = 5,
                NutritionId = Guid.Parse("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                Featured = false,
                Instructions = "1. Cook pasta. 2. Cook pancetta. 3. Mix eggs and cheese. 4. Combine all and season.",
                MealTypeId = 3,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Recipe
            {
                Id = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                Title = "Greek Salad",
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                Image = "https://example.com/images/greek-salad.jpg",
                Description = "A fresh and healthy salad made with tomatoes, cucumbers, onions, olives, and feta cheese.",
                CookingTime = "15 minutes",
                Servings = 2,
                DifficultyId = 1,
                DietaryInfoId = 11,
                NutritionId = Guid.Parse("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                Featured = true,
                Instructions = "1. Chop vegetables. 2. Mix in a bowl. 3. Add olives and feta cheese. 4. Drizzle with olive oil.",
                MealTypeId = 1,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Recipe
            {
                Id = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                Title = "Chicken Caesar Salad",
                UserId = Guid.Parse(Constants.SYSTEM_USER_ID),
                Image = "https://example.com/images/chicken-caesar-salad.jpg",
                Description = "A classic Caesar salad with grilled chicken, romaine lettuce, croutons, and Caesar dressing.",
                CookingTime = "20 minutes",
                Servings = 2,
                DifficultyId = 1,
                DietaryInfoId = 5,
                NutritionId = Guid.Parse("d4e4a728-8b91-4c8f-9e7d-c2f918c3b8b5"),
                Featured = false,
                Instructions = "1. Grill chicken. 2. Chop lettuce. 3. Mix lettuce, croutons, and dressing. 4. Top with chicken.",
                MealTypeId = 2,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Recipe
            {
                Id = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                Title = "Vegetable Stir Fry",
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                Image = "https://example.com/images/vegetable-stir-fry.jpg",
                Description = "A quick and easy stir fry with a variety of vegetables in a savory sauce.",
                CookingTime = "25 minutes",
                Servings = 3,
                DifficultyId = 2,
                DietaryInfoId = 11,
                NutritionId = Guid.Parse("c1b3e572-59a1-4e3e-8a5f-7f4a9b5e2c58"),
                Featured = false,
                Instructions = "1. Chop vegetables. 2. Stir fry in a hot pan. 3. Add sauce and cook until tender.",
                MealTypeId = 2,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Recipe
            {
                Id = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                Title = "Beef Tacos",
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                Image = "https://example.com/images/beef-tacos.jpg",
                Description = "Tasty tacos filled with seasoned beef, lettuce, cheese, and salsa.",
                CookingTime = "20 minutes",
                Servings = 4,
                DifficultyId = 1,
                DietaryInfoId = 1,
                NutritionId = Guid.Parse("e7b2a0de-5f15-4e7f-89f3-2a8e0c3e07d6"),
                Featured = true,
                Instructions = "1. Cook beef with seasoning. 2. Prepare taco shells. 3. Fill with beef and toppings.",
                MealTypeId = 3,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            }
        );
    }
}
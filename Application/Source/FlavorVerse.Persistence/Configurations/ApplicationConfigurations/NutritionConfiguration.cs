using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class NutritionConfiguration : BaseEntityConfiguration<Nutrition>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Nutrition> builder)
    {
        // Seed Data

        builder.HasData(
            new Nutrition
            {
                Id = Guid.Parse("b5e5f446-8d65-4b87-9652-9e89b3c8eabb"),
                Calories = 400,
                Protein = 15,
                Carbohydrates = 45,
                Fat = 20,
                Fiber = 2,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Nutrition
            {
                Id = Guid.Parse("a4f85b42-7a7b-4b7f-8368-2a96b6f9b8a3"),
                Calories = 150,
                Protein = 4,
                Carbohydrates = 10,
                Fat = 12,
                Fiber = 3,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Nutrition
            {
                Id = Guid.Parse("d4e4a728-8b91-4c8f-9e7d-c2f918c3b8b5"),
                Calories = 350,
                Protein = 30,
                Carbohydrates = 20,
                Fat = 15,
                Fiber = 3
            },
            new Nutrition
            {
                Id = Guid.Parse("c1b3e572-59a1-4e3e-8a5f-7f4a9b5e2c58"),
                Calories = 200,
                Protein = 5,
                Carbohydrates = 30,
                Fat = 8,
                Fiber = 6
            },
            new Nutrition
            {
                Id = Guid.Parse("e7b2a0de-5f15-4e7f-89f3-2a8e0c3e07d6"),
                Calories = 250,
                Protein = 20,
                Carbohydrates = 25,
                Fat = 10,
                Fiber = 4
            });
    }
}
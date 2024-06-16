using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RecipeIngredientConfiguration : IEntityTypeConfiguration<RecipeIngredient>
{
    public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
    {
        builder.HasKey(x => new { x.RecipeId, x.IngredientId });

        builder.Property(x => x.Quantity)
            .HasMaxLength(30);

        // Relationships

        builder.HasOne(x => x.Recipe)
            .WithMany(r => r.RecipeIngredients)
            .HasForeignKey(ri => ri.RecipeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Ingredient)
            .WithMany(i => i.RecipeIngredients)
            .HasForeignKey(ri => ri.IngredientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed Data

        builder.HasData(
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IngredientId = 17,
                Quantity = "200g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IngredientId = 15,
                Quantity = "3",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IngredientId = 18,
                Quantity = "100g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IngredientId = 19,
                Quantity = "150g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IngredientId = 20,
                Quantity = "to taste",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 21,
                Quantity = "1",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 9,
                Quantity = "2",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 22,
                Quantity = "1",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 23,
                Quantity = "100g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 5,
                Quantity = "3 tbsp",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 10,
                Quantity = "1 tbsp",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 24,
                Quantity = "1 tsp",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 3,
                Quantity = "to taste",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IngredientId = 25,
                Quantity = "50g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IngredientId = 26,
                Quantity = "1 head",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IngredientId = 11,
                Quantity = "200g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IngredientId = 27,
                Quantity = "100ml",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IngredientId = 28,
                Quantity = "50g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IngredientId = 18,
                Quantity = "50g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 29,
                Quantity = "2",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 30,
                Quantity = "1 head",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 31,
                Quantity = "2",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 32,
                Quantity = "3 tbsp",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 7,
                Quantity = "2 cloves",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 8,
                Quantity = "1",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 5,
                Quantity = "2 tbsp",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 3,
                Quantity = "to taste",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IngredientId = 4,
                Quantity = "to taste",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IngredientId = 12,
                Quantity = "200g",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IngredientId = 33,
                Quantity = "1 packet",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IngredientId = 34,
                Quantity = "4",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IngredientId = 35,
                Quantity = "1 cup, shredded",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IngredientId = 36,
                Quantity = "1 cup, shredded",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IngredientId = 37,
                Quantity = "1/2 cup",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new RecipeIngredient
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IngredientId = 38,
                Quantity = "1 cup",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            });
    }
}
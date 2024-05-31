using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RecipeCategoryConfiguration : IEntityTypeConfiguration<RecipeCategory>
{
    public void Configure(EntityTypeBuilder<RecipeCategory> builder)
    {
        builder.HasKey(x => new { x.RecipeId, x.CategoryId });

        // Relationships

        builder.HasOne(x => x.Recipe)
            .WithMany(r => r.RecipeCategories)
            .HasForeignKey(rc => rc.RecipeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Category)
            .WithMany(c => c.RecipeCategories)
            .HasForeignKey(rc => rc.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed Data

        builder.HasData(
            new RecipeCategory
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                CategoryId = 6
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                CategoryId = 1
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                CategoryId = 9
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                CategoryId = 3
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                CategoryId = 3
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                CategoryId = 1
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                CategoryId = 27
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                CategoryId = 14 // Stir Fry
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                CategoryId = 1
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                CategoryId = 1
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                CategoryId = 28
            },
            new RecipeCategory
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                CategoryId = 29
            });
    }
}
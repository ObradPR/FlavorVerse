using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RecipeCuisineConfiguration : IEntityTypeConfiguration<RecipeCuisine>
{
    public void Configure(EntityTypeBuilder<RecipeCuisine> builder)
    {
        builder.HasKey(x => new { x.RecipeId, x.CuisineId });

        // Relationships

        builder.HasOne(x => x.Recipe)
            .WithMany(r => r.RecipeCuisines)
            .HasForeignKey(rc => rc.RecipeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Cuisine)
            .WithMany(c => c.RecipeCuisines)
            .HasForeignKey(rc => rc.CuisineId)
            .OnDelete(DeleteBehavior.Restrict);

        // Seed Data

        builder.HasData(
            new RecipeCuisine
            {
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                CuisineId = 1
            },
            new RecipeCuisine
            {
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                CuisineId = 9
            },
            new RecipeCuisine
            {
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                CuisineId = 1
            },
            new RecipeCuisine
            {
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                CuisineId = 2
            },
            new RecipeCuisine
            {
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                CuisineId = 3
            }
);
    }
}
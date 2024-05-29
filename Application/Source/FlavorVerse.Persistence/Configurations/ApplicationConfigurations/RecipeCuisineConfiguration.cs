using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RecipeCuisineConfiguration : IEntityTypeConfiguration<RecipeCuisine>
{
    public void Configure(EntityTypeBuilder<RecipeCuisine> builder)
    {
        builder.HasKey(x => new { x.RecipeId, x.CuisineId });

        builder.HasOne(x => x.Recipe)
            .WithMany(r => r.RecipeCusines)
            .HasForeignKey(rc => rc.RecipeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Cuisine)
            .WithMany(c => c.RecipeCusines)
            .HasForeignKey(rc => rc.CuisineId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
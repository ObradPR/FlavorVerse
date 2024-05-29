using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RecipeCategoryConfiguration : IEntityTypeConfiguration<RecipeCategory>
{
    public void Configure(EntityTypeBuilder<RecipeCategory> builder)
    {
        builder.HasKey(x => new { x.RecipeId, x.CategoryId });

        builder.HasOne(x => x.Recipe)
            .WithMany(r => r.RecipeCategories)
            .HasForeignKey(rc => rc.RecipeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Category)
            .WithMany(c => c.RecipeCategories)
            .HasForeignKey(rc => rc.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
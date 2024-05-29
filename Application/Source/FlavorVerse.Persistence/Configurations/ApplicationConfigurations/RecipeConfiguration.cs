using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RecipeConfiguration : BaseEntityConfiguration<Recipe>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Recipe> builder)
    {
        builder.Property(x => x.Titile)
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
    }
}
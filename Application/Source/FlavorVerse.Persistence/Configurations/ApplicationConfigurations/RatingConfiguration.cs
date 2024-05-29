using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class RatingConfiguration : BaseEntityConfiguration<Rating>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Rating> builder)
    {
        builder.Property(x => x.Comment)
            .HasMaxLength(255);

        // Relationships

        builder.HasOne(x => x.Recipe)
            .WithMany(r => r.Ratings)
            .HasForeignKey(r => r.RecipeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(u => u.Ratings)
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
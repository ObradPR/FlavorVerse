using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class NutritionConfiguration : BaseEntityConfiguration<Nutrition>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Nutrition> builder)
    {
    }
}
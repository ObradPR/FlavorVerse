using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.Application_luConfigurations;

internal class MealType_luConfiguration : BaseEntity_luConfiguration<MealType_lu>
{
    protected override void ConfigureEntity(EntityTypeBuilder<MealType_lu> builder)

    {
        builder.HasData(
            new MealType_lu { Id = (int)eMealType.Breakfast, Name = eMealType.Breakfast.ToString() },
            new MealType_lu { Id = (int)eMealType.Lunch, Name = eMealType.Lunch.ToString() },
            new MealType_lu { Id = (int)eMealType.Dinner, Name = eMealType.Dinner.ToString() },
            new MealType_lu { Id = (int)eMealType.Snack, Name = eMealType.Snack.ToString() },
            new MealType_lu { Id = (int)eMealType.Dessert, Name = eMealType.Dessert.ToString() });
    }
}
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.Application_luConfigurations;

internal class EntityType_luConfiguration : BaseEntity_luConfiguration<EntityType_lu>
{
    protected override void ConfigureEntity(EntityTypeBuilder<EntityType_lu> builder)
    {
        builder.HasData(
            new EntityType_lu { Id = (int)eEntityType.User, Name = eEntityType.User.ToString() },
            new EntityType_lu { Id = (int)eEntityType.Nutrition, Name = eEntityType.Nutrition.ToString() },
            new EntityType_lu { Id = (int)eEntityType.Rating, Name = eEntityType.Rating.ToString() },
            new EntityType_lu { Id = (int)eEntityType.Recipe, Name = eEntityType.Recipe.ToString() },
            new EntityType_lu { Id = (int)eEntityType.Cuisine, Name = eEntityType.Cuisine.ToString() },
            new EntityType_lu { Id = (int)eEntityType.Ingredient, Name = eEntityType.Ingredient.ToString() },
            new EntityType_lu { Id = (int)eEntityType.Category, Name = eEntityType.Category.ToString() },
            new EntityType_lu { Id = (int)eEntityType.RecipeCategory, Name = eEntityType.RecipeCategory.ToString() },
            new EntityType_lu { Id = (int)eEntityType.RecipeIngredient, Name = eEntityType.RecipeIngredient.ToString() },
            new EntityType_lu { Id = (int)eEntityType.RecipeCuisine, Name = eEntityType.RecipeCuisine.ToString() }
            );
    }
}
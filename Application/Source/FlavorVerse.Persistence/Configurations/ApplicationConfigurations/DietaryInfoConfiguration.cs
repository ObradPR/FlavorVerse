using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class DietaryInfoConfiguration : IEntityTypeConfiguration<DietaryInfo>
{
    public void Configure(EntityTypeBuilder<DietaryInfo> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasData(
            new DietaryInfo
            {
                Id = 1,
                GlutenFree = false,
                DairyFree = false,
                Vegetarian = false,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 2,
                GlutenFree = false,
                DairyFree = false,
                Vegetarian = false,
                Vegan = true
            },
            new DietaryInfo
            {
                Id = 3,
                GlutenFree = false,
                DairyFree = false,
                Vegetarian = true,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 4,
                GlutenFree = false,
                DairyFree = false,
                Vegetarian = true,
                Vegan = true
            },
            new DietaryInfo
            {
                Id = 5,
                GlutenFree = false,
                DairyFree = true,
                Vegetarian = false,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 6,
                GlutenFree = false,
                DairyFree = true,
                Vegetarian = false,
                Vegan = true
            },
            new DietaryInfo
            {
                Id = 7,
                GlutenFree = false,
                DairyFree = true,
                Vegetarian = true,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 8,
                GlutenFree = false,
                DairyFree = true,
                Vegetarian = true,
                Vegan = true
            },
            new DietaryInfo
            {
                Id = 9,
                GlutenFree = true,
                DairyFree = false,
                Vegetarian = false,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 10,
                GlutenFree = true,
                DairyFree = false,
                Vegetarian = false,
                Vegan = true
            },
            new DietaryInfo
            {
                Id = 11,
                GlutenFree = true,
                DairyFree = false,
                Vegetarian = true,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 12,
                GlutenFree = true,
                DairyFree = false,
                Vegetarian = true,
                Vegan = true
            },
            new DietaryInfo
            {
                Id = 13,
                GlutenFree = true,
                DairyFree = true,
                Vegetarian = false,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 14,
                GlutenFree = true,
                DairyFree = true,
                Vegetarian = false,
                Vegan = true
            },
            new DietaryInfo
            {
                Id = 15,
                GlutenFree = true,
                DairyFree = true,
                Vegetarian = true,
                Vegan = false
            },
            new DietaryInfo
            {
                Id = 16,
                GlutenFree = true,
                DairyFree = true,
                Vegetarian = true,
                Vegan = true
            });
    }
}
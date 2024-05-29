using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class CuisineConfiguration : BaseEntity_luConfiguration<Cuisine>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Cuisine> builder)
    {
        builder.Property(x => x.Description)
            .HasMaxLength(100);

        builder.Property(x => x.Image)
            .HasMaxLength(255);

        builder.HasData(
            new Cuisine
            {
                Id = 1,
                Name = "Italian",
                Description = "Famous for pasta, pizza, and rich sauces.",
                Image = "https://flagsapi.com/IT/flat/64.png"
            },
            new Cuisine
            {
                Id = 2,
                Name = "Chinese",
                Description = "Known for noodles, dumplings, and diverse flavors.",
                Image = "https://flagsapi.com/CN/flat/64.png"
            },
            new Cuisine
            {
                Id = 3,
                Name = "Mexican",
                Description = "Popular for tacos, burritos, and spicy dishes.",
                Image = "https://flagsapi.com/MX/flat/64.png"
            },
            new Cuisine
            {
                Id = 4,
                Name = "Japanese",
                Description = "Renowned for sushi, ramen, and tempura.",
                Image = "https://flagsapi.com/JP/flat/64.png"
            },
            new Cuisine
            {
                Id = 5,
                Name = "Indian",
                Description = "Known for curries, spices, and diverse vegetarian dishes.",
                Image = "https://flagsapi.com/IN/flat/64.png"
            },
            new Cuisine
            {
                Id = 6,
                Name = "French",
                Description = "Famous for pastries, wine, and sophisticated flavors.",
                Image = "https://flagsapi.com/FR/flat/64.png"
            },
            new Cuisine
            {
                Id = 7,
                Name = "Thai",
                Description = "Known for its spicy curries and vibrant flavors.",
                Image = "https://flagsapi.com/TH/flat/64.png"
            },
            new Cuisine
            {
                Id = 8,
                Name = "Spanish",
                Description = "Popular for tapas, paella, and rich traditions.",
                Image = "https://flagsapi.com/ES/flat/64.png"
            },
            new Cuisine
            {
                Id = 9,
                Name = "Greek",
                Description = "Famous for gyros, olives, and feta cheese.",
                Image = "https://flagsapi.com/GR/flat/64.png"
            },
            new Cuisine
            {
                Id = 10,
                Name = "Lebanese",
                Description = "Known for meze, kebabs, and fresh salads.",
                Image = "https://flagsapi.com/LB/flat/64.png"
            },
            new Cuisine
            {
                Id = 11,
                Name = "Turkish",
                Description = "Famous for kebabs, baklava, and strong coffee.",
                Image = "https://flagsapi.com/TR/flat/64.png"
            },
            new Cuisine
            {
                Id = 12,
                Name = "Korean",
                Description = "Popular for kimchi, BBQ, and vibrant dishes.",
                Image = "https://flagsapi.com/KR/flat/64.png"
            },
            new Cuisine
            {
                Id = 13,
                Name = "Brazilian",
                Description = "Known for churrasco, feijoada, and tropical flavors.",
                Image = "https://flagsapi.com/BR/flat/64.png"
            },
            new Cuisine
            {
                Id = 14,
                Name = "Moroccan",
                Description = "Famous for tagines, couscous, and rich spices.",
                Image = "https://flagsapi.com/MA/flat/64.png"
            },
            new Cuisine
            {
                Id = 15,
                Name = "Vietnamese",
                Description = "Known for pho, fresh herbs, and light dishes.",
                Image = "https://flagsapi.com/VN/flat/64.png"
            },
            new Cuisine
            {
                Id = 16,
                Name = "Ethiopian",
                Description = "Popular for injera, stews, and communal eating.",
                Image = "https://flagsapi.com/ET/flat/64.png"
            });
    }
}
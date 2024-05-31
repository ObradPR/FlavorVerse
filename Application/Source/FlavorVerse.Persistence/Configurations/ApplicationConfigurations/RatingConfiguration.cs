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

        // Seed Data

        builder.HasData(
            new Rating
            {
                Id = Guid.Parse("fe403647-fc55-47a5-bdc8-d33966b2d883"),
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                RatingValue = 8,
                Comment = "Great recipe!",
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddMinutes(-57),
            },
            new Rating
            {
                Id = Guid.Parse("0d5c49a4-bba0-4d7f-9f4a-43de6838da2b"),
                UserId = Guid.Parse("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                RatingValue = 10,
                Comment = "Delicious!",
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddMinutes(-22),
            },
            new Rating
            {
                Id = Guid.Parse("bdfe1e3d-4ffa-4ab6-993b-7b885ff75702"),
                UserId = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                RatingValue = 2,
                Comment = "I didn't like it.",
                RecipeId = Guid.Parse("2ebd6b8b-fdfc-4459-863b-87c6177ec7d3"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddHours(-1),
            },

            new Rating
            {
                Id = Guid.Parse("e889e176-fb02-432c-bfff-c6617f4f58d0"),
                UserId = Guid.Parse("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                RatingValue = 6,
                Comment = "Refreshing!",
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddHours(-1).AddMinutes(10),
            },
            new Rating
            {
                Id = Guid.Parse("abf7c036-c39c-4517-8fc6-2082dd5cf223"),
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                RatingValue = 8,
                Comment = "Simple and tasty.",
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Rating
            {
                Id = Guid.Parse("6de00555-feeb-4ad0-922d-25810973c8d0"),
                UserId = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                RatingValue = 7,
                Comment = "Could use more seasoning.",
                RecipeId = Guid.Parse("4536c788-0357-4cd8-bac7-b94ca0562750"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddHours(-10),
            },

            new Rating
            {
                Id = Guid.Parse("68513c99-a253-4098-b52a-2d65c3048992"),
                UserId = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                RatingValue = 5,
                Comment = "Classic dish!",
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IsActive = false,
                CreatedAt = DateTime.UtcNow,
            },
            new Rating
            {
                Id = Guid.Parse("ec766a0f-a568-42a4-a566-5ffe39c42791"),
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                RatingValue = 3,
                Comment = "Could be more flavorful.",
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddMinutes(-10),
            },
            new Rating
            {
                Id = Guid.Parse("61bfc7f0-b242-46b1-a364-27887eb871a3"),
                UserId = Guid.Parse("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                RatingValue = 9,
                Comment = "Healthy and delicious!",
                RecipeId = Guid.Parse("1812b4be-517c-4a54-a834-ef63b1ca3a10"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },

            new Rating
            {
                Id = Guid.Parse("d3ba8d81-6ceb-40af-a03d-2ac8a6cdf17e"),
                UserId = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                RatingValue = 9,
                Comment = "Quick and easy dinner!",
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddHours(-22),
            },
            new Rating
            {
                Id = Guid.Parse("9e4b0164-0346-473e-9e79-a13623c975ca"),
                UserId = Guid.Parse("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                RatingValue = 10,
                Comment = "Tasty!",
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Rating
            {
                Id = Guid.Parse("7f7fc389-cdb5-409e-b4a9-e6000b4e6ce2"),
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                RatingValue = 4,
                Comment = "Could use more sauce.",
                RecipeId = Guid.Parse("0ba9e673-81b3-44cf-917a-ef14777b7bcf"),
                IsActive = false,
                CreatedAt = DateTime.UtcNow.AddHours(-1),
            },

            new Rating
            {
                Id = Guid.Parse("4b86773a-092e-4554-88fe-74743a78973c"),
                UserId = Guid.Parse("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                RatingValue = 7,
                Comment = "Authentic flavors!",
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddHours(-10),
            },
            new Rating
            {
                Id = Guid.Parse("3923b038-e1ec-40af-bfd5-8470a4acd647"),
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                RatingValue = 6,
                Comment = "A bit too spicy for my taste.",
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
            },
            new Rating
            {
                Id = Guid.Parse("54dea16a-6838-47f6-978b-0cff6def6b3e"),
                UserId = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                RatingValue = 8,
                Comment = "Tastes like authentic street tacos!",
                RecipeId = Guid.Parse("bf2ed32b-8d90-45bc-ba78-3669916c74b6"),
                IsActive = true,
                CreatedAt = DateTime.UtcNow.AddHours(-3),
            });
    }
}
using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class CategoryConfiguration : BaseEntity_luConfiguration<Category>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Category> builder)
    {
        builder.HasOne(x => x.Parent)
            .WithMany(p => p.ChildCategories)
            .HasForeignKey(c => c.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
               new Category { Id = 1, Name = "Main Courses", ParentId = null },
               new Category { Id = 2, Name = "Appetizers", ParentId = null },
               new Category { Id = 3, Name = "Salads", ParentId = null },
               new Category { Id = 4, Name = "Desserts", ParentId = null },
               new Category { Id = 5, Name = "Seafood", ParentId = 1 },
               new Category { Id = 6, Name = "Pasta", ParentId = 1 },
               new Category { Id = 7, Name = "Soup", ParentId = 2 },
               new Category { Id = 8, Name = "Dips", ParentId = 2 },
               new Category { Id = 9, Name = "Greek Salad", ParentId = 3 },
               new Category { Id = 10, Name = "Fruit Salad", ParentId = 3 },
               new Category { Id = 11, Name = "Cakes", ParentId = 4 },
               new Category { Id = 12, Name = "Cookies", ParentId = 4 },
               new Category { Id = 13, Name = "Grilled", ParentId = 1 },
               new Category { Id = 14, Name = "Stir Fry", ParentId = 1 },
               new Category { Id = 15, Name = "Sandwiches", ParentId = 1 },
               new Category { Id = 16, Name = "Stews", ParentId = 1 },
               new Category { Id = 17, Name = "Burgers", ParentId = 1 },
               new Category { Id = 18, Name = "Barbecue", ParentId = 1 },
               new Category { Id = 19, Name = "Pizza", ParentId = 1 },
               new Category { Id = 20, Name = "Wraps", ParentId = 1 },
               new Category { Id = 21, Name = "Finger Foods", ParentId = 2 },
               new Category { Id = 22, Name = "Spring Rolls", ParentId = 2 },
               new Category { Id = 23, Name = "Mixed Greens", ParentId = 3 },
               new Category { Id = 24, Name = "Coleslaw", ParentId = 3 },
               new Category { Id = 25, Name = "Mousse", ParentId = 4 },
               new Category { Id = 26, Name = "Pies", ParentId = 4 });
    }
}
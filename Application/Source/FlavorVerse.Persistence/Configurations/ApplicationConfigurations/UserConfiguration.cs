using FlavorVerse.Application.Identity.Services;
using FlavorVerse.Common;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class UserConfiguration : BaseEntityConfiguration<User>
{
    protected override void ConfigureEntity(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(x => x.DisplayName)
            .HasMaxLength(60)
            .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(100);
        builder.HasIndex(x => x.Email)
            .IsUnique();

        builder.HasData(
            new User
            {
                Id = Guid.Parse(Constants.SYSTEM_USER_ID),
                Email = "system@dmin.test",
                Password = UserService.HashPassword("Pa$$w0rd"),
                FirstName = "Obrad",
                LastName = "Pualić-Radujko",
                DateOfBirth = new DateOnly(2002, 10, 10),
                CreatedAt = DateTime.UtcNow
            });
    }
}
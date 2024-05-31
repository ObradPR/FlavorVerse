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

        // Seed Data

        builder.HasData(
            new User
            {
                Id = Guid.Parse(Constants.SYSTEM_USER_ID),
                Email = "system@dmin.test",
                Phone = "0000000000",
                Password = UserService.HashPassword("Pa$$w0rd"),
                FirstName = "Obrad",
                LastName = "Pualić-Radujko",
                DateOfBirth = new DateOnly(2002, 10, 10),
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                Email = "vnemanjic@gmail.com",
                Phone = "0661261261",
                Password = UserService.HashPassword("Pa$$w0rd"),
                FirstName = "Vukota",
                LastName = "Nemanjić",
                DateOfBirth = new DateOnly(1995, 12, 29),
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = Guid.Parse("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                Email = "nenad.obradovic221@gmail.com",
                Phone = "0646464646",
                Password = UserService.HashPassword("Pa$$w0rd"),
                FirstName = "Nenad",
                LastName = "Obradović",
                DateOfBirth = new DateOnly(1999, 3, 18),
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                Email = "branko.pr@gmail.com",
                Phone = "0612323232",
                Password = UserService.HashPassword("Pa$$w0rd"),
                FirstName = "Branko",
                LastName = "Pualić-Radujko",
                DateOfBirth = new DateOnly(2002, 10, 10),
                CreatedAt = DateTime.UtcNow
            });
    }
}
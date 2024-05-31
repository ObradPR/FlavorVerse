using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FlavorVerse.Common;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(x => new { x.UserId, x.RoleId });

        builder.HasOne(x => x.Role)
            .WithMany(r => r.UserRoles)
            .HasForeignKey(x => x.RoleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new UserRole
            {
                UserId = Guid.Parse(Constants.SYSTEM_USER_ID),
                RoleId = (int)eUserRole.Admin
            },
            new UserRole
            {
                UserId = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                RoleId = (int)eUserRole.Admin,
            },
            new UserRole
            {
                UserId = Guid.Parse("030c3159-d298-41d5-9ba4-b65fe274cbae"),
                RoleId = (int)eUserRole.Member,
            },
            new UserRole
            {
                UserId = Guid.Parse("99e3dc0d-b4ec-4a00-a7fc-208fc3ce6d08"),
                RoleId = (int)eUserRole.Member,
            },
            new UserRole
            {
                UserId = Guid.Parse("5642960e-c7c6-40bf-a8d8-7d7457dc1212"),
                RoleId = (int)eUserRole.Member,
            });
    }
}
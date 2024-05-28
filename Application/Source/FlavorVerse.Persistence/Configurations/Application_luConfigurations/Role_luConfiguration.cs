using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.Application_luConfigurations;

internal class Role_luConfiguration : BaseEntity_luConfiguration<Role_lu>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Role_lu> builder)
    {
        builder.HasData(
            new Role_lu { Id = (int)eUserRole.Admin, Name = eUserRole.Admin.ToString() },
            new Role_lu { Id = (int)eUserRole.Member, Name = eUserRole.Member.ToString() });
    }
}
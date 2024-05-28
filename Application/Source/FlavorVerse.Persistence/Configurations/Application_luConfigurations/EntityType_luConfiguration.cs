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
            new EntityType_lu { Id = (int)eEntityType.User, Name = eEntityType.User.ToString() });
    }
}
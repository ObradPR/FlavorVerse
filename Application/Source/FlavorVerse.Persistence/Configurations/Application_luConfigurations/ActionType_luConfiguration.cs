using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.Application_luConfigurations;

internal class ActionType_luConfiguration : BaseEntity_luConfiguration<ActionType_lu>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ActionType_lu> builder)
    {
        builder.HasData(
            new ActionType_lu { Id = (int)eActionType.Insert, Name = eActionType.Insert.ToString() },
            new ActionType_lu { Id = (int)eActionType.Update, Name = eActionType.Update.ToString() },
            new ActionType_lu { Id = (int)eActionType.Delete, Name = eActionType.Delete.ToString() });
    }
}
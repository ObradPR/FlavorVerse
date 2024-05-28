using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Persistence.Configurations._BaseConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.Application_luConfigurations;

internal class DifficultyCooking_luConfiguration : BaseEntity_luConfiguration<DifficultyCooking_lu>
{
    protected override void ConfigureEntity(EntityTypeBuilder<DifficultyCooking_lu> builder)

    {
        builder.HasData(
            new DifficultyCooking_lu { Id = (int)eDifficultyCooking.Easy, Name = eDifficultyCooking.Easy.ToString() },
            new DifficultyCooking_lu { Id = (int)eDifficultyCooking.Medium, Name = eDifficultyCooking.Medium.ToString() },
            new DifficultyCooking_lu { Id = (int)eDifficultyCooking.Hard, Name = eDifficultyCooking.Hard.ToString() },
            new DifficultyCooking_lu { Id = (int)eDifficultyCooking.Expert, Name = eDifficultyCooking.Expert.ToString() });
    }
}
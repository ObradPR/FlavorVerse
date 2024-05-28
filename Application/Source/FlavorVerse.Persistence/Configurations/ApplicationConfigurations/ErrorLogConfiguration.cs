using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class ErrorLogConfiguration
{
    public void Configure(EntityTypeBuilder<ErrorLog> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Message)
            .IsRequired();

        builder.Property(x => x.StackTrace)
            .IsRequired();
    }
}
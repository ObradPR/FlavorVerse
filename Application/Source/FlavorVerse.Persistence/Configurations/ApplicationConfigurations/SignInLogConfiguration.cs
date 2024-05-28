using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class SigninLogConfiguration : IEntityTypeConfiguration<SignInLog>
{
    public void Configure(EntityTypeBuilder<SignInLog> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(u => u.SignInLogs)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
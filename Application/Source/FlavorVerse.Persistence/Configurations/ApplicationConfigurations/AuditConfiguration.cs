using FlavorVerse.Domain.Entities.Application;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlavorVerse.Persistence.Configurations.ApplicationConfigurations;

internal class AuditConfiguration : IEntityTypeConfiguration<Audit>
{
    public void Configure(EntityTypeBuilder<Audit> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(u => u.Audits)
            .HasForeignKey(x => x.ExecutedById)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.EntityType)
            .WithMany(et => et.Audits)
            .HasForeignKey(x => x.EntityTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.ActionType)
            .WithMany(at => at.Audits)
            .HasForeignKey(x => x.ActionTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
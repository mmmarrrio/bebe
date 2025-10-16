using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class AttemptModelConfig : IEntityTypeConfiguration<AttemptModel>
{
    public void Configure(EntityTypeBuilder<AttemptModel> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.StartedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasOne(a => a.Test).WithMany(t => t.Attempts).HasForeignKey(a => a.TestId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(a => a.Student).WithMany(s => s.Attempts).HasForeignKey(a => a.StudentId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(a => a.UserAttemptAnswers).WithOne(uaa => uaa.Attempt);

        builder.HasMany(a => a.TestResults).WithOne(tr => tr.Attempt);
    }
}
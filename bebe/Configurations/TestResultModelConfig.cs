using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class TestResultModelConfig : IEntityTypeConfiguration<TestResultModel>
{
    public void Configure(EntityTypeBuilder<TestResultModel> builder)
    {
        builder.HasKey(tr => tr.Id);
        builder.HasAlternateKey(tr => new { tr.TestId, tr.AttemptId, tr.StudentId });

        builder.HasOne(tr => tr.Test).WithMany(t => t.TestResults).HasForeignKey(tr => tr.TestId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(tr => tr.Attempt).WithMany(a => a.TestResults).HasForeignKey(tr => tr.AttemptId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(tr => tr.Student).WithMany(s => s.TestResults).HasForeignKey(tr => tr.StudentId).OnDelete(DeleteBehavior.Cascade);
    }
}
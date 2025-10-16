using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class QuestionModelConfig : IEntityTypeConfiguration<QuestionModel>
{
    public void Configure(EntityTypeBuilder<QuestionModel> builder)
    {
        builder.HasKey(q => q.Id);
        builder.HasAlternateKey(q => new { q.TestId, q.Number }); 

        builder.Property(q => q.Description).HasMaxLength(2000);

        builder.HasOne(q => q.Test).WithMany(t => t.Questions).HasForeignKey(q => q.TestId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(q => q.UserAttemptAnswers).WithOne(uaa => uaa.Question);
        builder.HasMany(q => q.Answers).WithOne(a => a.Question);
    }
}
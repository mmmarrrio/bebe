using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class UserAttemptAnswerModelConfig : IEntityTypeConfiguration<UserAttemptAnswerModel>
{
    public void Configure(EntityTypeBuilder<UserAttemptAnswerModel> builder)
    {
        builder.HasKey(uaa => uaa.Id);
        builder.HasAlternateKey(uaa => new { uaa.AttemptId, uaa.QuestionId });

        builder.HasOne(uaa => uaa.Attempt).WithMany(a => a.UserAttemptAnswers).HasForeignKey(uaa => uaa.AttemptId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(uaa => uaa.Question).WithMany(q => q.UserAttemptAnswers).HasForeignKey(uaa => uaa.QuestionId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(uaa => uaa.UserSelectedOptions).WithOne(uso => uso.UserAttemptAnswer);
        builder.HasOne(uaa => uaa.UserTextAnswer).WithOne(uta => uta.UserAttemptAnswer);
    }
}
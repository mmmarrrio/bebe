using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class AnswerModelConfig : IEntityTypeConfiguration<AnswerModel>
{
    public void Configure(EntityTypeBuilder<AnswerModel> builder)
    {
        builder.HasKey(a => a.Id);

        builder.HasOne(a => a.Question).WithMany(q => q.Answers).HasForeignKey(a => a.QuestionId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(a => a.UserSelectedOptions).WithOne(uso => uso.Answer);
    }
}
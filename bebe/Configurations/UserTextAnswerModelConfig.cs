using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class UserTextAnswerModelConfig : IEntityTypeConfiguration<UserTextAnswerModel>
{
    public void Configure(EntityTypeBuilder<UserTextAnswerModel> builder)
    {
        builder.HasKey(uta => uta.Id);

        builder.HasOne(uta => uta.UserAttemptAnswer).WithOne(uaa => uaa.UserTextAnswer).HasForeignKey<UserTextAnswerModel>(uta => uta.UserAttemptAnswerId).OnDelete(DeleteBehavior.Cascade);
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class UserSelectedOptionModelConfig : IEntityTypeConfiguration<UserSelectedOptionModel>
{
    public void Configure(EntityTypeBuilder<UserSelectedOptionModel> builder)
    {
        builder.HasKey(uso => uso.Id);

        builder.HasOne(uso => uso.UserAttemptAnswer).WithMany(uaa => uaa.UserSelectedOptions).HasForeignKey(uso => uso.UserAttemptAnswerId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(uso => uso.Answer).WithMany(a => a.UserSelectedOptions).HasForeignKey(uso => uso.AnswerId).OnDelete(DeleteBehavior.Restrict);
    }
}
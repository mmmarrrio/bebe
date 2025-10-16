using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class UserModelConfig : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => u.Login).IsUnique();
        builder.HasIndex(u => u.Email).IsUnique();

        builder.Property(u => u.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasOne(u => u.Student).WithOne(s => s.User);
    }
}
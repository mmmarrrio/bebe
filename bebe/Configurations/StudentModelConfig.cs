using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class StudentModelConfig : IEntityTypeConfiguration<StudentModel>
{
    public void Configure(EntityTypeBuilder<StudentModel> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Phone).HasMaxLength(30);

        builder.HasOne(s => s.User).WithOne(u => u.Student).HasForeignKey<StudentModel>(s => s.UserId);
        builder.HasMany(s => s.Groups).WithMany(g => g.Students);
        builder.HasMany(s => s.Tests).WithMany(t => t.Students);
        builder.HasMany(s => s.Attempts).WithOne(a => a.Student);
        builder.HasMany(s => s.TestResults).WithOne(tr => tr.Student);
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class CourseModelConfig : IEntityTypeConfiguration<CourseModel>
{
    public void Configure(EntityTypeBuilder<CourseModel> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasIndex(c => c.Name).IsUnique();

        builder.HasMany(c => c.Groups).WithOne(g => g.Course);
        builder.HasMany(c => c.Tests).WithMany(t => t.Courses);
    }
}
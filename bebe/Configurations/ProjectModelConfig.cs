using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class ProjectModelConfig : IEntityTypeConfiguration<ProjectModel>
{
    public void Configure(EntityTypeBuilder<ProjectModel> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.Name).IsUnique();

        builder.HasMany(p => p.Groups).WithOne(g => g.Project);
        builder.HasMany(p => p.Tests).WithMany(t => t.Projects);
    }
}
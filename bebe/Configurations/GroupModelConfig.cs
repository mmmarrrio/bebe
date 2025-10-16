using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class GroupModelConfig : IEntityTypeConfiguration<GroupModel>
{
    public void Configure(EntityTypeBuilder<GroupModel> builder)
    {
        builder.HasKey(g => g.Id);

        builder.HasIndex(g => g.Name).IsUnique();

        builder.HasOne(g => g.Direction).WithMany(d => d.Groups).HasForeignKey(g => g.DirectionId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(g => g.Course).WithMany(c => c.Groups).HasForeignKey(g => g.CourseId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(g => g.Project).WithMany(p => p.Groups).HasForeignKey(g => g.ProjectId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(g => g.Students).WithMany(s => s.Groups);
        builder.HasMany(g => g.Tests).WithMany(t => t.Groups);
    }
}
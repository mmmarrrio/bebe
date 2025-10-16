using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class TestModelConfig : IEntityTypeConfiguration<TestModel>
{
    public void Configure(EntityTypeBuilder<TestModel> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasMany(t => t.Questions).WithOne(q => q.Test).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(t => t.Students).WithMany(s => s.Tests);
        builder.HasMany(t => t.Projects).WithMany(p => p.Tests);
        builder.HasMany(t => t.Courses).WithMany(c => c.Tests);
        builder.HasMany(t => t.Groups).WithMany(g => g.Tests);
        builder.HasMany(t => t.Directions).WithMany(d => d.Tests);
        
        builder.HasMany(t => t.Attempts).WithOne(a => a.Test);
        builder.HasMany(t => t.TestResults).WithOne(tr => tr.Test);
    }
}
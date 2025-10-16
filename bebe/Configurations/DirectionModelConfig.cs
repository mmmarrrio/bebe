using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace UniversityEF;

public class DirectionModelConfig : IEntityTypeConfiguration<DirectionModel>
{
    public void Configure(EntityTypeBuilder<DirectionModel> builder)
    {
        builder.HasKey(d => d.Id);

        builder.HasIndex(d => d.Name).IsUnique();

        builder.HasMany(d => d.Groups).WithOne(g => g.Direction);
        builder.HasMany(d => d.Tests).WithMany(t => t.Directions);
    }
}
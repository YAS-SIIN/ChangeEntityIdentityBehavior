using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChangeEntityIdentityBehavior.Domain.Entities;

public class Test
{
  public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual TestDetail TestDetail { get; set; }

    public void Map(EntityTypeBuilder<Test> builder)
    {
        builder.ToTable("Test");
         
        builder.Property(c => c.Name).HasMaxLength(100);
        builder.Property(c => c.Description).HasMaxLength(200);

    }
}

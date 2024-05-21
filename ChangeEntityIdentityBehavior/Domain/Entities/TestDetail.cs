using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Hosting;

namespace ChangeEntityIdentityBehavior.Domain.Entities;

public class TestDetail
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }

    public virtual Test Test { get; set; }
    public void Map(EntityTypeBuilder<TestDetail> builder)
    {
        builder.ToTable("TestDetail");
         
        builder.Property(c => c.Title).HasMaxLength(100);
        builder.Property(c => c.Url).HasMaxLength(200);

    }
}
using ChangeEntityIdentityBehavior.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Reflection.Emit;

namespace ChangeEntityIdentityBehavior.Infrastructure.Data;

public class MainContext : DbContext 
{

    public MainContext(DbContextOptions options) : base(options)
    {
    }
    #region Test    
    public DbSet<Test> Tests { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //var mutableProperties = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.Name == "Status"));

        #region Test 
        var testBuilder = modelBuilder.Entity<Test>();
        testBuilder.ToTable("Test");
        testBuilder.Property(c => c.Id).ValueGeneratedOnAdd();
        testBuilder.Property(c => c.Name).HasMaxLength(100);
        testBuilder.Property(c => c.Description).HasMaxLength(200);

        #endregion

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly); base.OnModelCreating(modelBuilder);
    }

}

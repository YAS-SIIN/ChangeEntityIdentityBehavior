using ChangeEntityIdentityBehavior.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Reflection.Emit;

namespace ChangeEntityIdentityBehavior.Infrastructure.Data;

public class MainContext : DbContext 
{

    public MainContext() : base()
    {

    }
    #region Test    
    public DbSet<Test> Tests { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //var mutableProperties = modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.Name == "Status"));

        #region Employee 

        #endregion
        var testBuilder = modelBuilder.Entity<Test>();
        testBuilder.ToTable("Employee", schema: "EMP");
        testBuilder.Property(c => c.Id).ValueGeneratedOnAdd();

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly); base.OnModelCreating(modelBuilder);
    }

}

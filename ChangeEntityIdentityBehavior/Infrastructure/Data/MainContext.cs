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
 

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainContext).Assembly); base.OnModelCreating(modelBuilder);
    }

}

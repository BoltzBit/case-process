using Microsoft.EntityFrameworkCore;
using CaseProcess.Core.Entities;
using System.Reflection;

namespace CaseProcess.Infra.Context;

public class ProcessDbContext : DbContext
{
    public ProcessDbContext(DbContextOptions<ProcessDbContext> options)
        :base(options)
    {
    }

    public DbSet<Process> Processes { get; set; }
    public DbSet<CompanyArea> CompanyAreas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return result;
    }

    public override int SaveChanges()
    {
        return SaveChangesAsync().GetAwaiter().GetResult();
    }
}
using Microsoft.EntityFrameworkCore;
using SpaSalon.Domain.Entities;

namespace SpaSalon.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<SpaProcedureType> SpaProcedureTypes => Set<SpaProcedureType>();
    public DbSet<SpaProcedure> SpaProcedures => Set<SpaProcedure>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SpaProcedure>()
            .HasOne(p => p.SpaProcedureType)
            .WithMany(t => t.Procedures)
            .HasForeignKey(p => p.SpaProcedureTypeId);
    }
}

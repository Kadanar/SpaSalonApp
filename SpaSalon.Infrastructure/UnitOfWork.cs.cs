using SpaSalon.Application.Interfaces;
using SpaSalon.Domain.Entities;
using SpaSalon.Infrastructure.Data;
using SpaSalon.Infrastructure.Repositories;

namespace SpaSalon.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IRepository<SpaProcedureType> SpaProcedureTypes { get; }
    public IRepository<SpaProcedure> SpaProcedures { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        SpaProcedureTypes = new Repository<SpaProcedureType>(_context);
        SpaProcedures = new Repository<SpaProcedure>(_context);
    }

    public async Task SaveAsync()
        => await _context.SaveChangesAsync();
}

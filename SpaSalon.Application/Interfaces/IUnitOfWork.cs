using SpaSalon.Domain.Entities;

namespace SpaSalon.Application.Interfaces;

public interface IUnitOfWork
{
    IRepository<SpaProcedureType> SpaProcedureTypes { get; }
    IRepository<SpaProcedure> SpaProcedures { get; }
    Task SaveAsync();
}

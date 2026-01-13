namespace SpaSalon.Domain.Entities;

public class SpaProcedureType
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public ICollection<SpaProcedure> Procedures { get; set; }
        = new List<SpaProcedure>();
}

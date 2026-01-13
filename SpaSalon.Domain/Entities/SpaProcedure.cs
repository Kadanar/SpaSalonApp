namespace SpaSalon.Domain.Entities;

public class SpaProcedure
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int DurationMinutes { get; set; }

    public decimal Price { get; set; }
    public string Therapist { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;

    public int SpaProcedureTypeId { get; set; }
    public SpaProcedureType SpaProcedureType { get; set; } = null!;
}

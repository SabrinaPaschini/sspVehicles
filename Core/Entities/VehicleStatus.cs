namespace Core.Entities;

public class VehicleStatus
{
    public int Id { get; set; }
    public required string StatusName { get; set; } // disponivel, reservado, em manutencão e vendido 
    public int VehicleId { get; set; }
}


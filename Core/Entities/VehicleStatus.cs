namespace Core.Entities;

public class VehicleStatus
{
    public int VehicleStatusId { get; set; }
    public required string StatusName { get; set; } // disponivel, reservado, em manutencão e vendido 
    public int VehicleId { get; set; }
}


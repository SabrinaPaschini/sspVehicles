namespace Core.Entities;

public class Vehicle
{
    public int VehicleId { get; set; }
    public required string Model { get; set; }
    public required int Year { get; set; }
    public required string Automaker { get; set; }
    public required decimal Price { get; set; }
}
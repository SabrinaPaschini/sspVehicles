namespace Core.Entities;
public class Vehicle
{
    public int VehicleId { get; set; }
    public int Year { get; set; }
    public string Automaker { get; set; }
    public decimal Price { get; set; }

    public int VehicleStatusId { get; set; }
    public VehicleStatus VehicleStatus { get; set; }
}
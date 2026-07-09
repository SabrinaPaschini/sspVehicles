namespace SSP.Vehicles.Web.Models;
public class Vehicle
{
    public int VehicleId { get; set; }
    public int Year { get; set; }
    public string Automaker { get; set; }
    public decimal Price { get; set; }
    public string VehicleStatusId { get; set; }
    public string FipeCode { get; set; }
    public string FipeFuel { get; set; }
    public string FipeModel { get; set; }
    public string Color { get; set; }
}
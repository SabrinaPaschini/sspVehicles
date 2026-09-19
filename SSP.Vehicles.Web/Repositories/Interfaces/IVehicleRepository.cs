using SSP.Vehicles.Web.Models;

namespace SSP.Vehicles.Web.Repositories.Interfaces;

public interface IVehicleRepository
{
    int Add(Vehicle vehicle);
    IEnumerable<Vehicle> GetAll();
}
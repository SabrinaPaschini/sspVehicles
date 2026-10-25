using System.Data;
using Dapper;
using SSP.Vehicles.Web.Data;
using SSP.Vehicles.Web.Models;
using SSP.Vehicles.Web.Repositories.Interfaces;

namespace SSP.Vehicles.Web.Repositories;

public class VehicleRepository : IVehicleRepository
{
    private readonly DapperContext _context;

    public VehicleRepository(DapperContext context)
    {
        _context = context;
    }

    public int Add(Vehicle vehicle)
    {
        using var connection = _context.CreateConnection();

        var parameters = new
        {
            vehicle.Year,
            vehicle.Automaker,
            vehicle.Price,
            vehicle.VehicleStatusId,
            vehicle.FipeCode,
            vehicle.FipeFuel,
            vehicle.FipeModel,
            vehicle.Color, 
            vehicle.LicensePlate
        };

        var id = connection.QuerySingle<int>(
            "SP_ADD_Vehicle",
            parameters,
            commandType: CommandType.StoredProcedure
        );
            

        return id;
    }

    public IEnumerable<Vehicle> GetAll()
    {
        using var connection = _context.CreateConnection();

        var vehicles = connection.Query<Vehicle>(
            "SP_LST_Vehicles",
            commandType: CommandType.StoredProcedure
        );

        return vehicles;
    }

    public Vehicle? GetVehicleById(int id)
    {
        using var connection = _context.CreateConnection();

        var vehicle = connection.QuerySingleOrDefault<Vehicle>(
            "SP_GET_VehicleById", 
            new {VehicleId = id },
            commandType: CommandType.StoredProcedure
        );

        return vehicle; 
    }
    
    public int Update(Vehicle vehicle)
    {
        using var connection = _context.CreateConnection();

        var parameters = new
        {	
            vehicle.VehicleId,
            vehicle.Year,
            vehicle.Automaker,
            vehicle.Price,
            vehicle.FipeCode,
            vehicle.FipeFuel,
            vehicle.FipeModel,
            vehicle.Color, 
            vehicle.LicensePlate
        };

        var affectedRows = connection.Execute("SP_UPD_Vehicle", parameters, commandType: CommandType.StoredProcedure);
        return affectedRows;
    }

    public int Delete(Vehicle vehicle)
    {
        using var connection = _context.CreateConnection();

        var parameters = new
        {
            vehicle.VehicleId
        };

        var rowsAffected = connection.Execute(
            "SP_DEL_Vehicle",
            parameters,
            commandType: CommandType.StoredProcedure
        );
        return rowsAffected;
    }
}
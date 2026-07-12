using Dapper;
using System.Data;
using SSP.Vehicles.Web.Data;
using SSP.Vehicles.Web.Models;

using SSP.Vehicles.Web.Repositories.Interfaces;

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
            vehicle.Color
        };

        var id = connection.QuerySingle<int>(
            "SP_ADD_Vehicle",
            parameters,
            commandType: CommandType.StoredProcedure
        );

        return id;
    }
}
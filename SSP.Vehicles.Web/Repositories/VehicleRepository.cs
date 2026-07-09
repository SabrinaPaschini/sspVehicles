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
        using var context = _context.CreateConnection();

        return context.QuerySingle<int>(
            "SP_ADD_Vehicle",
            vehicle,
            commandType: CommandType.StoredProcedure
        );
    }
}
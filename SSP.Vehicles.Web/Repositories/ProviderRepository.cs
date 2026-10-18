using System.Data;
using Dapper;
using SSP.Vehicles.Web.Models;
using SSP.Vehicles.Web.Data;
using SSP.Vehicles.Web.Repositories.Interfaces;


namespace SSP.Vehicles.Web.Repositories;

public class ProviderRepository : IProviderRepository
{
    private readonly DapperContext _context;

    public ProviderRepository(DapperContext dapperContext)
    {
        _context = dapperContext;
    }
    public int Add(Provider provider)
    {
        using var connection = _context.CreateConnection();

        var parameters = new
        {
            provider.Name,
            provider.Email,
            provider.Phone,
            provider.Address,
            provider.City,
            provider.State,
            provider.Zip,
            provider.Country
        };
        var id = connection.ExecuteScalar<int>(
            "SP_ADD_Provider",
            parameters,
            commandType:CommandType.StoredProcedure
        );
        return id;
    }

    public List<Provider> GetAll()
    {
        using var connection = _context.CreateConnection();
        
        
        var providers = connection.Query<Provider>(
            "SP_LST_Provider",
            commandType: CommandType.StoredProcedure
            );
        return providers.ToList();

    }
}
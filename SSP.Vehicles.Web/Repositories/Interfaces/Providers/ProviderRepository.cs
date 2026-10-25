using System.Data;
using Dapper;
using Microsoft.CodeAnalysis;
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
        
        var id = connection.QuerySingle<int>(
            "SP_ADD_Provider",
            parameters,
            commandType: CommandType.StoredProcedure
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

    public int UpdateProvider(Provider provider)
    {
        using var connection = _context.CreateConnection();
        
        var parameters = new
        {
            provider.ProviderId,
            provider.Name,
            provider.Email,
            provider.Phone,
            provider.Address,
            provider.City,
            provider.State,
            provider.Zip,
            provider.Country
        };
        
        var affectedRows = connection.Execute(
            "SP_UPD_Provider",
            parameters,
            commandType: CommandType.StoredProcedure
        );
        
        return affectedRows;
    }

    public Provider? GetProviderById(int id)
    {
        using var connection = _context.CreateConnection();

        var provider = connection.QuerySingleOrDefault<Provider>(
            "SP_GET_ProviderById",
            new { ProviderId = id },
            commandType: CommandType.StoredProcedure
        );
        return provider;
    }
  }

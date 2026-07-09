using Microsoft.Data.SqlClient;
using System.Data;

namespace SSP.Vehicles.Web.Data;

public class DapperContext // responsavel por abrir a conexao, ler a conection string...
{
    private readonly IConfiguration _configuration;

    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(
            _configuration.GetConnectionString("DefaultConnection"));
    }
}
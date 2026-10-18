using SSP.Vehicles.Web.Models;

namespace SSP.Vehicles.Web.Repositories.Interfaces;

public interface IProviderRepository
{
    int Add(Provider provider);
    List<Provider> GetAll();
}
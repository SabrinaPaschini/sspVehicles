using Microsoft.AspNetCore.Mvc;
using SSP.Vehicles.Web.Models;
using SSP.Vehicles.Web.Repositories.Interfaces;

namespace SSP.Vehicles.Web.Controllers;


public class ProviderController : Controller
{
    private readonly IProviderRepository  _providerRepository;

    public ProviderController(IProviderRepository providerRepository)
    {
        _providerRepository = providerRepository;
    }

    [HttpPost]
    public IActionResult Add(Provider provider)
    {
        if (!ModelState.IsValid)
        {
            return Index();
        }
        var providerId = _providerRepository.Add(provider);
        
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult AddProvider()
    {
        Provider provider = null;
        var  providerId = _providerRepository.Add(provider);
        return RedirectToAction(nameof(Index));
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var providers = _providerRepository.GetAll();
        
        return View("ListProviders", providers);
    }
}
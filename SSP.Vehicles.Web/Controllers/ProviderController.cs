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

    [HttpGet]
    public IActionResult AddProviders()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddProviders(Provider provider)
    {
        if (!ModelState.IsValid)
        {
            return View(provider);
        }
        var id = _providerRepository.Add(provider);     
        
        return RedirectToAction(nameof(ListProviders)); // precisa receber o nome da action de destino. 
    }
        
    [HttpGet]
    public IActionResult ListProviders()
    {
        var providers = _providerRepository.GetAll();
        
        return View("ListProviders", providers);
    }

    [HttpGet]
    public IActionResult EditProvider(int id)
    {
        var providers = _providerRepository.GetProviderById(id);

        if (providers == null)
        {
            return NotFound();
        }

        return View("EditProviders", providers);
        }

    [HttpPost]
    public IActionResult EditProvider(Provider provider)
    {
        if (!ModelState.IsValid)
        {
            return View("EditProviders", provider);
        }
        var affectedRows = _providerRepository.UpdateProvider(provider);
        
        if (affectedRows < 0)
        {
            return NotFound();
        }    
        return RedirectToAction(nameof(ListProviders));
        
    }
}

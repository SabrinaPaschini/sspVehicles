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
       
        
        return View("AddProviders");
    }

    [HttpGet]
    public IActionResult AddProviders(Provider provider)
    {
        if (!ModelState.IsValid)
        {
            return View(provider);
        }
        var id = _providerRepository.Add(provider);     
        return RedirectToAction("ListProviders", id);
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var providers = _providerRepository.GetAll();
        
        return View("ListProviders", providers);
    }
}
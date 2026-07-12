using Microsoft.AspNetCore.Mvc;
using SSP.Vehicles.Web.Models;
using SSP.Vehicles.Web.Repositories.Interfaces;

namespace SSP.Vehicles.Web.Controllers;

public class VehiclesController : Controller
{
    private readonly IVehicleRepository _vehicleRepository; // injecao de dependencia 

    public VehiclesController(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository; 
    }


    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Create(Vehicle vehicle)
    {
        if (!ModelState.IsValid)
        {
            return View(vehicle);
        }

        var id = _vehicleRepository.Add(vehicle);

        return RedirectToAction("Index");
    }
}
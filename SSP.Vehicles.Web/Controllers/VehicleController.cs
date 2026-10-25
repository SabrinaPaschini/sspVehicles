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
    public IActionResult AddVehicles()
    {
        return View();
    }

    [HttpGet]
    public IActionResult ListVehicles()
    {
        var vehicles = _vehicleRepository.GetAll();
        return View(vehicles);
    }

    [HttpPost]
    public IActionResult AddVehicles(Vehicle vehicle)
    {
        if (!ModelState.IsValid)
        {
            return View(vehicle);
        }

        var id = _vehicleRepository.Add(vehicle);

        return RedirectToAction(nameof(ListVehicles));
    }

    [HttpGet]
    public IActionResult EditVehicles(int id)
    {
        var vehicle = _vehicleRepository.GetVehicleById(id);

        if (vehicle is null)
        {
            return NotFound();
        }

        return View(vehicle);
    }

    [HttpPost]
    public IActionResult EditVehicles(Vehicle vehicle)
    {
        if (!ModelState.IsValid)
        {
            return View(vehicle);
        }

        var affectedRows = _vehicleRepository.Update(vehicle);

        if (affectedRows == 0)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(ListVehicles));
    }

    [HttpGet]
    public IActionResult DeleteVehicles(int id)
    {
        var vehicle = _vehicleRepository.GetVehicleById(id);

        if (vehicle is null)
        {
            return NotFound();
        }

        return View(vehicle);
    }

    [HttpPost]
    public IActionResult DeleteVehicles(Vehicle vehicle)
    {
        if (!ModelState.IsValid)
        {
            return View(vehicle);
        }

        var affectedRows = _vehicleRepository.Delete(vehicle);

        if (affectedRows == 0)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(ListVehicles));
    }
    
    
}

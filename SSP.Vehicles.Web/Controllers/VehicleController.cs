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

    [HttpGet]
    public IActionResult Index()
    {
        var vehicles = _vehicleRepository.GetAll();
        return View(vehicles);
    }

    [HttpPost]
    public IActionResult Create(Vehicle vehicle)
    {
        if (!ModelState.IsValid)
        {
            return View(vehicle);
        }

        var id = _vehicleRepository.Add(vehicle);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var vehicle = _vehicleRepository.GetVehicleById(id);

		if (vehicle is null )
	{
		return NotFound();
	}
        return View(vehicle);
    }

// TODO: action que faz um post e recebe os dados do formulario 

	[HttpPost] 
	public IActionResult Edit(Vehicle vehicle)
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
		return RedirectToAction(nameof(Index));
	}
}

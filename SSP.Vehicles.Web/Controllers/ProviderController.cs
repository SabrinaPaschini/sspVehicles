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
    // TODO 3: Receber int id no GET e buscar o fornecedor pelo repository.
    // GET e POST precisam de assinaturas C# distintas; mudar so o nome do parametro nao diferencia metodos.
    public IActionResult EditProvider()
    {
        var providers = _providerRepository.GetProviderById(id);

        if (providers == null)
        {
            return NotFound();
        }
        
        // TODO 3: Indicar a view EditProviders, pois seu arquivo tem nome diferente da action EditProvider.
        return View(providers);
        }

    [HttpPost]
    public IActionResult EditProvider(Provider provider)
    {
        // TODO 4: Validar ModelState antes de salvar; se invalido, devolver EditProviders com o provider recebido.
        // Validar tambem o token antifalsificacao enviado pelo formulario.
        // TODO 4: Passar provider ao UpdateProvider; id nao existe neste metodo.
        // Guardar o retorno em outra variavel: provider ja e o nome do parametro e o retorno e int.
        var provider = _providerRepository.UpdateProvider(id);
        
        // TODO 4: Verificar a quantidade de linhas afetadas (zero), em vez de comparar com null.
        if (provider == null)
        {
            // TODO 4: Completar a instrucao abaixo com ponto e virgula.
            return NotFound()
        }
        
        return RedirectToAction(nameof(ListProviders));
    }
}

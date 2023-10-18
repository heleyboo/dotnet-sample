using webapi.Models;
using webapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;
    public PizzaController(ILogger<PizzaController> logger)
    {
        _logger = logger;
    }

    // GET all action

    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();
    
    [HttpGet("/companies")]
    public async Task<List<Company>> GetAllCompanies()
    {
        _logger.LogInformation("=========");
        _logger.LogInformation(AppDomain.CurrentDomain.BaseDirectory);
        return await PizzaService.GetAllCompany();
    }



    // GET by Id action

    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null)
            return NotFound();

        return pizza;
    }

    // POST action

    // PUT action

    // DELETE action
}
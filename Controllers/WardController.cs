using Microsoft.AspNetCore.Mvc;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Services.Interfaces;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WardController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;

    private readonly IWardService _wardService;
    
    public WardController(ILogger<PizzaController> logger, IWardService wardService)
    {
        _logger = logger;
        _wardService = wardService;
    }

    [HttpGet("/wards")]
    public async Task<List<Ward>> getWards()
    {
        return await _wardService.getWardsByDistrictCode("773");
    }
    
}
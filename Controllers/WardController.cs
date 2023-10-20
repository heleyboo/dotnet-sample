using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.DataTransferObjects;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Services.Interfaces;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class WardController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;

    private readonly IMapper _mapper;

    private readonly IWardService _wardService;
    
    public WardController(ILogger<PizzaController> logger, IWardService wardService, IMapper iMapper)
    {
        _logger = logger;
        _wardService = wardService;
        _mapper = iMapper;
    }

    [HttpGet("{code}")]
    public ActionResult<Ward?> Get(string code)
    {
        return _wardService.GetWardByCode(code);
    }

    [HttpGet("/wards")]
    public async Task<List<WardDto>> GetWards([FromQuery(Name = "districtCode")] string districtCode)
    {
        _logger.LogInformation(districtCode);
        
        return await MapperConfig.InitializeAutomapper().Map<Task<List<WardDto>>>(_wardService.GetWardsByDistrictCode(districtCode));
    }
}
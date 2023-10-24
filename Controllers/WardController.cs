using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.DataTransferObjects;
using webapi.Models.BoardNumber;
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
    
    private readonly IGameUserService _gameUserService;
    
    public WardController(ILogger<PizzaController> logger, IWardService wardService, IMapper iMapper, IGameUserService gameUserService)
    {
        _logger = logger;
        _wardService = wardService;
        _mapper = iMapper;
        _gameUserService = gameUserService;
    }

    [HttpGet("{code}")]
    public ActionResult<Ward?> Get(string code)
    {
        return _wardService.GetWardByCode(code);
    }

    [HttpGet("/wards")]
    public IEnumerable<WardDto> GetWards([FromQuery(Name = "districtCode")] string districtCode)
    {
        _logger.LogInformation(districtCode);
        
        return _mapper.Map<IEnumerable<WardDto>>(_wardService.GetWardsByDistrictCode(districtCode));
    }
    
    [HttpGet("/districts")]
    public async Task<List<DistrictDto>> GetDistricts()
    {
        return await _mapper.Map<Task<List<DistrictDto>>>(_wardService.GetAllDistricts());
    }
    
    [HttpPost("/users")]
    public GameUser Store(GameUser gameUser)
    {
        _logger.LogInformation(gameUser.Username);
        return _gameUserService.CreateUser(gameUser);
    }
}
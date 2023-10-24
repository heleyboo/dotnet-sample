using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapi.DataTransferObjects.Request;
using webapi.Models.BoardNumber;
using webapi.Repositories;
using webapi.Repositories.Interfaces;
using webapi.Services.Interfaces;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class GameUserController : ControllerBase
{
    private readonly ILogger<GameUserController> _logger;

    private readonly IGameUserService _gameUserService;

    private readonly IUnitOfWork _unitOfWork;
    
    public GameUserController(ILogger<GameUserController> logger, IGameUserService gameUserService, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
        _gameUserService = gameUserService;
    }

    [HttpGet("{id}")]
    public ActionResult<GameUser?> Get(int id)
    {
        return _unitOfWork.GameUser.GetById(id);
    }

    [HttpPost("/game-users")]
    public GameUser Store(GameUser gameUser)
    {
        return _gameUserService.CreateUser(gameUser);
    }

    [HttpPost("/game-users/{deviceId}")]
    public GameUser? Update(string deviceId, UpdateGameUserRequest gameUser)
    {
        return _unitOfWork.GameUser.UpdateNameByDeviceId(deviceId, gameUser.Username);
    }
}
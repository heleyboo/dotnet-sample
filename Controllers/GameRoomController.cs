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
public class GameRoomController : ControllerBase
{
    private readonly ILogger<GameUserController> _logger;

    private readonly IUnitOfWork _unitOfWork;
    
    public GameRoomController(ILogger<GameUserController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    [HttpGet("{id}")]
    public ActionResult<GameUser?> Get(int id)
    {
        return _unitOfWork.GameUser.GetById(id);
    }
    
    [HttpGet("/rooms")]
    public RoomList GetAllRooms()
    {
        IEnumerable<Room> res = _unitOfWork.GameRoom.GetAll();
        return new RoomList() { Rooms = res.ToList() };
    }

    [HttpPost("/rooms")]
    public Room CreateRoom(CreateRoomRequest createRoomRequest)
    {
        return _unitOfWork.GameRoom.Add(Room.CreateRandom(createRoomRequest.RoomName));
    }
}
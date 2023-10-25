using Microsoft.AspNetCore.SignalR;
using webapi.Models.BoardNumber;
using webapi.Repositories.Interfaces;

namespace webapi.Hubs;

public class GameHub : Hub
{
    private readonly IUnitOfWork _unitOfWork;

    public GameHub(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task JoinRoom(string roomCode, string deviceId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, roomCode);
        await Clients.Group(roomCode).SendAsync("PlayerJoined", Context.ConnectionId);

        Room room = _unitOfWork.GameRoom.GetByCode(roomCode);
        
        await Clients.Group(roomCode).SendAsync("GameData", room);
    }

    public async Task OutRoom(string roomCode, string deviceId)
    {
        
    }
    public async Task SendMove(string roomName, string move)
    {
        await Clients.Group(roomName).SendAsync("ReceiveMove", move);
    }
}
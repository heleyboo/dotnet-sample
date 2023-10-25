using webapi.Models.BoardNumber;
using webapi.Repositories.Interfaces;
using webapi.Services.Interfaces;

namespace webapi.Services;

public class GameService: IGameService
{
    private readonly IUnitOfWork _unitOfWork;

    public GameService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public Room JoinRoom(Room room, string deviceId)
    {
        return null;
    }

    public Room OutRoom(Room room, string deviceId)
    {
        return null;
    }

    public GameUser GetByDeviceId(string deviceId)
    {
        return null;
    }
}
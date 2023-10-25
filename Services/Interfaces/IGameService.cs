using webapi.Models.BoardNumber;

namespace webapi.Services.Interfaces;

public interface IGameService
{
    public Room JoinRoom(Room room, string deviceId);
    public Room OutRoom(Room room, string deviceId);
    public GameUser GetByDeviceId(string deviceId);
}
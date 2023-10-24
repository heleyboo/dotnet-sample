using webapi.Models.BoardNumber;

namespace webapi.Repositories.Interfaces;

public interface IGameUserRepository: IGenericRepository<GameUser>
{
    public GameUser? UpdateNameByDeviceId(string deviceId, string name);

    public GameUser? FindByDeviceId(string deviceId);
}
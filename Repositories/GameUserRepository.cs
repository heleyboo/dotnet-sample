using webapi.DbContext;
using webapi.Models.BoardNumber;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Repositories.Interfaces;

namespace webapi.Repositories;

public class GameUserRepository: GenericRepository<GameUser>, IGameUserRepository
{
    public GameUserRepository(AdministrativeDataContext context) : base(context) {}

    public GameUser? UpdateNameByDeviceId(string deviceId, string name)
    {
        var gameUser = FindByDeviceId(deviceId);

        if (gameUser != null)
        {
            gameUser.Username = name;
            context.Update(gameUser);
            context.SaveChanges();
        }

        return gameUser;
    }

    public GameUser? FindByDeviceId(string deviceId)
    {
        return Find(g => g.DeviceId == deviceId).SingleOrDefault();
    }
}
using webapi.Models.BoardNumber;
using webapi.Repositories;
using webapi.Repositories.Interfaces;
using webapi.Services.Interfaces;

namespace webapi.Services;

public class GameUserService: IGameUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public GameUserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public GameUser CreateUser(GameUser gameUser)
    {
        var gameUserObject = _unitOfWork.GameUser.FindByDeviceId(gameUser.DeviceId);
        if (gameUserObject == null)
        {
            return _unitOfWork.GameUser.Add(gameUser);
        }

        return gameUserObject;
    }
}
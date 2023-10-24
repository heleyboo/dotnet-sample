using webapi.Models.BoardNumber;

namespace webapi.Services.Interfaces;

public interface IGameUserService
{
    public GameUser CreateUser(GameUser gameUser);
}
using webapi.Models.BoardNumber;

namespace webapi.Repositories.Interfaces;

public interface IGameRoomRepository: IGenericRepository<Room>
{
    public Room? GetByCode(string code);
}
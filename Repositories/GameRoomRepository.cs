using webapi.DbContext;
using webapi.Models.BoardNumber;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Repositories.Interfaces;

namespace webapi.Repositories;

public class GameRoomRepository: GenericRepository<Room>, IGameRoomRepository
{
    public GameRoomRepository(AdministrativeDataContext context) : base(context) {}

    public Room? GetByCode(string code)
    {
        return Find(g => g.Code == code).SingleOrDefault();
    }
}
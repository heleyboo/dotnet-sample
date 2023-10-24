using webapi.DbContext;
using webapi.Models.BoardNumber;
using webapi.Models.VietnameseAdministrativeUnits;
using webapi.Repositories.Interfaces;

namespace webapi.Repositories;

public class UnitOfWork: IUnitOfWork {
    private AdministrativeDataContext context;
    public UnitOfWork(AdministrativeDataContext context) {
        this.context = context;
        Ward = new WardRepository(this.context);
        GameUser = new GameUserRepository(this.context);
        GameRoom = new GameRoomRepository(this.context);
    }
    public IWardRepository Ward { get; }
    public IGameUserRepository GameUser { get; }
    public IGameRoomRepository GameRoom { get; }
    
    public void Dispose() {
        context.Dispose();
    }
    public int Save() {
        return context.SaveChanges();
    }
}
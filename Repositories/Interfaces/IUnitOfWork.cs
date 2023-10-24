namespace webapi.Repositories.Interfaces;

public interface IUnitOfWork: IDisposable {
    IWardRepository Ward { get; }

    IGameUserRepository GameUser { get; }
    
    IGameRoomRepository GameRoom { get; }
    int Save();
}
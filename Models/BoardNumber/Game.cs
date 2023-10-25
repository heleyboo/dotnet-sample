namespace webapi.Models.BoardNumber;

public class GameData
{
    public int Id { get; set; }
    public string? RoomCode { get; set; }
    public string? FirstPlayerId { get; set; }
    public string? SecondPlayerId { get; set; }
    public string? WinnerId { get; set; }
    public int? FirstPlayerScore { get; set; }
    public int? SecondPlayerScore { get; set; }
    public bool? AllPlayersReady { get; set; }
    public List<int>? GameMatrix { get; set; }
    public List<int>? FirstPlayerFound { get; set; }
    public List<int>? SecondPlayerFound { get; set; }
}
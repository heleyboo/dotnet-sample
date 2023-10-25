using System.Text.Json;

namespace webapi.Models.BoardNumber;

public class Room
{
    public int Id { get; set; }
    
    public string Code { get; set; }
    
    public string? Name { get; set; }
    
    public string? Board { get; set; }
    
    public List<int>? BoardNumber { get; set; }
    
    public int? FirstPlayerId { get; set; }
    
    public int? SecondPlayerId { get; set; }

    public static Room CreateRandom(string roomName)
    {
        List<int> board = RandomNumberGenerator.RandomBoard();

        string boardJson = JsonSerializer.Serialize(board);
        
        return new Room()
        {
            Code = RandomNumberGenerator.GenerateRandomNumberString(6),
            Name = roomName,
            BoardNumber = board,
            Board = boardJson
        };
    }
}

public class RoomList
{
    public List<Room> Rooms { get; set; }
}

public static class RandomNumberGenerator
{
    public static string GenerateRandomNumberString(int numbers)
    {
        Random random = new Random();
        string randomString = "";

        for (int i = 0; i < numbers; i++)
        {
            // Generate a random digit (0-9) and append it to the string
            randomString += random.Next(10).ToString();
        }

        return randomString;
    }
    
    public static List<int> RandomBoard()
    {
        // Create a list of integers from 1 to 100
        List<int> integerList = new List<int>();
        for (int i = 1; i <= 100; i++)
        {
            integerList.Add(i);
        }

        // Create a random number generator
        Random random = new Random();

        // Shuffle the list using the Fisher-Yates shuffle algorithm
        for (int i = integerList.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            int temp = integerList[i];
            integerList[i] = integerList[j];
            integerList[j] = temp;
        }

        return integerList;
    }
}
namespace TrybeGames;

public enum GameType {
    Action,
    Adventure,
    Puzzle,
    Strategy,
    Simulation,
    Sports,
    Other
};

public class Game
{
    public int Id;

    public string Name = "";

    public DateTime ReleaseDate;

    public GameType GameType;

    public int DeveloperStudio;

    public List<int> Players = new List<int>();

    public void AddPlayer(Player playerToAdd)
    {
        Players.Add(playerToAdd.Id);
    }

    public void RemovePlayer(Player playerToRemove)
    {
        Players.Remove(playerToRemove.Id);
    }
}

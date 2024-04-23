namespace TrybeGames;
public class GamePlayer
{
    public string GameName = "";
    public List<Player>? Players { get; set; }
}
public class StudioGamesPlayers
{
    public string? GameStudioName { get; set; }
    public List<GamePlayer>? Games { get; set; }
}

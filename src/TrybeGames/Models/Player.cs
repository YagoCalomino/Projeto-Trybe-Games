namespace TrybeGames;

public class Player
{
    public int Id;

    public string Name = "";

    public List<int> FavoriteGameStudios = new List<int>();

    public List<int> GamesOwned = new List<int>();

    public void AddGameStudioToFavorites(GameStudio gameStudioToAdd)
    {
        FavoriteGameStudios.Add(gameStudioToAdd.Id);
    }

    public void BuyGame(Game gameToBuy)
    {
        GamesOwned.Add(gameToBuy.Id);
    }
}

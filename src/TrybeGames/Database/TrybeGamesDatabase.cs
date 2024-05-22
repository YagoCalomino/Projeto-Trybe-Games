namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        var filteredGames = Games.Where(game => game.DeveloperStudio == gameStudio.Id).ToList();
        return filteredGames;
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        var playerGames = from game in Games
                        from playerGame in game.Players
                        where playerGame == player.Id
                        select game;

        var playerGamesList = playerGames.ToList();
        return playerGamesList;
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        var filteredGames = from game in Games
                            from playerGame in game.Players
                            where playerGame == playerEntry.Id
                            select game;

        return filteredGames.ToList();
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        var gameStudioList = from studio in GameStudios
                            join game in Games on studio.Id equals game.DeveloperStudio
                            select new GameWithStudio
                            {
                                GameName = game.Name,
                                StudioName = studio.Name,
                                NumberOfPlayers = game.Players.Count
                            };

        return gameStudioList.ToList();
    }
    
    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        var gameTypes = from game in Games
                        group game by game.GameType into types
                        select types.Key;

        return gameTypes.ToList();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        var list = GameStudios.Select(studio => new StudioGamesPlayers
        {
            GameStudioName = studio.Name,
            Games = Games.Where(game => game.DeveloperStudio == studio.Id)
                        .Select(game => new GamePlayer
                        {
                            GameName = game.Name,
                            Players = Players.Join(game.Players, player => player.Id, playerGame => playerGame, (player, playerGame) => player)
                                            .ToList()
                        })
                        .ToList()
        });

        return list.ToList();
    }

}

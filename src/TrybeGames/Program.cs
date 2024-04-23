using System;
using TrybeGames;

class People
{
    public string? Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var database = new TrybeGamesDatabase(){
            Games = new List<Game>(){
                new Game(){
                    Id = 1,
                    Name = "Super Mario Bros.",
                    ReleaseDate = new DateTime(1985, 9, 13),
                    DeveloperStudio = 1,
                    Players = new List<int>(){1}
                },
                new Game(){
                    Id = 2,
                    Name = "Sonic the Hedgehog",
                    ReleaseDate = new DateTime(1991, 1, 1),
                    DeveloperStudio = 2,
                    Players = new List<int>(){1}
                },
                new Game(){
                    Id = 3,
                    Name = "Super Mario Kart",
                    ReleaseDate = new DateTime(1992, 1, 1),
                    DeveloperStudio = 1,
                    Players = new List<int>(){1}
                },
                new Game(){
                    Id = 4,
                    Name = "Crash Bandicoot",
                    ReleaseDate = new DateTime(1996, 9, 9),
                    DeveloperStudio = 3,
                    Players = new List<int>(){1}
                },
            },
            GameStudios = new List<GameStudio>(){
                new GameStudio(){
                    Id = 1,
                    Name = "Nintendo",
                    CreatedAt = new DateTime(1889, 9, 23)
                },
                new GameStudio(){
                    Id = 2,
                    Name = "Sega",
                    CreatedAt = new DateTime(1951, 1, 1)
                },
                new GameStudio(){
                    Id = 3,
                    Name = "Naughty Dog",
                    CreatedAt = new DateTime(1984, 9, 27)
                },
            },
            Players = new List<Player>(){
                new Player(){
                    Id = 1,
                    Name = "Arthur",
                    FavoriteGameStudios = new List<int>(){1, 2},
                    GamesOwned = new List<int>(){1, 2}
                },
            },
        };

        var controller = new TrybeGamesController(database, new ConsoleWrapper());

        Console.WriteLine("Boas vindas ao sistema de gerenciamento de jogos Trybe Games!");
        MainMenuLoop(controller);
        Console.WriteLine("Obrigado por usar o sistema de gerenciamento de jogos Trybe Games!");
    }

    public static void PrintMainMenu()
    {
        Console.WriteLine("Selecione um opção do menu abaixo:");
        Console.WriteLine("1 - Adicionar jogos, jogadores e estúdios");
        Console.WriteLine("2 - Consultar jogos, jogadores e estúdios");
        Console.WriteLine("3 - Editar informações do jogador");
        Console.WriteLine("4 - Editar informações do jogo");
        Console.WriteLine("5 - Sair");
    }

    public static void PrintAddMenu()
    {
        Console.WriteLine("1 - Adicionar novo jogador");
        Console.WriteLine("2 - Adicionar novo estúdio de jogos");
        Console.WriteLine("3 - Adicionar novo jogo");
        Console.WriteLine("4 - Voltar");
    }

    public static void PrintQueryMenu()
    {
        Console.WriteLine("1 - Consultar jogos de um Estúdio de jogos");
        Console.WriteLine("2 - Consultar jogos jogados por um jogador");
        Console.WriteLine("3 - Consultar jogos comprados por um jogador");
        Console.WriteLine("4 - Voltar");
    }

    public static void PrintPlayerMenu()
    {
        Console.WriteLine("1 - Comprar jogo");
        Console.WriteLine("2 - Adicionar estúdio de jogos aos favoritos");
        Console.WriteLine("3 - Voltar");
    }

    public static void PrintGamesMenu()
    {
        Console.WriteLine("1 - Adicionar novo jogador");
        Console.WriteLine("2 - Remover jogador");
        Console.WriteLine("3 - Trocar estúdio de jogos");
        Console.WriteLine("4 - Voltar");
    }

    public static void MainMenuLoop(TrybeGamesController controller)
    {
        var menu = 0;
        while (menu != 5)
        {
            PrintMainMenu();
            menu = int.Parse(Console.ReadLine() ?? "0");
            switch (menu)
            {
                case 1:
                    AddMenuLoop(controller);
                    break;
                case 2:
                    QueryMenuLoop(controller);
                    break;
                case 3:
                    PlayerMenuLoop(controller);
                    break;
                case 4:
                    GameMenuLoop(controller);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }

    public static void GameMenuLoop(TrybeGamesController controller)
    {
        var game = controller.SelectGame(controller.database.Games);
        if (game == null)
        {
            Console.WriteLine("Jogo não encontrado!");
            return;
        }
        var menu = 0;
        while (menu != 4)
        {
            PrintGamesMenu();
            menu = int.Parse(Console.ReadLine() ?? "0");
            switch (menu)
            {
                case 1:
                    controller.AddPlayerToGame(game);
                    break;
                case 2:
                    controller.RemovePlayerFromGame(game);
                    break;
                case 3:
                    controller.ChangeGameStudio(game);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
        Console.WriteLine("Voltando ao menu principal...");
    }

    public static void PlayerMenuLoop(TrybeGamesController controller)
    {
        var player = controller.SelectPlayer(controller.database.Players);
        if (player == null)
        {
            Console.WriteLine("Pessoa jogadora não encontrada!");
            return;
        }
        var menu = 0;
        while (menu != 3)
        {
            PrintPlayerMenu();
            menu = int.Parse(Console.ReadLine() ?? "0");
            switch (menu)
            {
                case 1:
                    controller.BuyGame(player);
                    break;
                case 2:
                    controller.AddGameStudioToFavorites(player);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
        Console.WriteLine("Voltando ao menu principal...");
    }

    public static void QueryMenuLoop(TrybeGamesController controller)
    {
        var menu = 0;
        while (menu != 4)
        {
            PrintQueryMenu();
            menu = int.Parse(Console.ReadLine() ?? "0");
            switch (menu)
            {
                case 1:
                    controller.QueryGamesFromStudio();
                    break;
                case 2:
                    controller.QueryGamesPlayedByPlayer();
                    break;
                case 3:
                    controller.QueryGamesBoughtByPlayer();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
        Console.WriteLine("Voltando ao menu principal...");
    }

    public static void AddMenuLoop(TrybeGamesController controller)
    {
        var menu = 0;
        while (menu != 4)
        {
            PrintAddMenu();
            menu = int.Parse(Console.ReadLine() ?? "0");
            switch (menu)
            {
                case 1:
                    controller.AddPlayer();
                    break;
                case 2:
                    controller.AddGameStudio();
                    break;
                case 3:
                    controller.AddGame();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
        Console.WriteLine("Voltando ao menu principal...");
    }
}

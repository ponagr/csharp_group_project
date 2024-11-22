using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        Textures.PrintFirstScreen();
        Highscore.LoadHighScore();
        bool inMenu = true;
        bool playAgain = false;

        while (inMenu)
        {
            // Lägga till funktion att välja med wasd eller upp och ner tangenterna?
            Console.Clear();
            Console.SetCursorPosition(44, 9);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********** MAINMENU **********");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(44, 10);
            Console.Write("        1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("New Game");
            Console.SetCursorPosition(44, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Highscores");
            Console.SetCursorPosition(44, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        3. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quit Game");
            Console.SetCursorPosition(44, 13);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******************************");
            Console.ResetColor();
            var choice = Console.ReadKey(true);
            List<Map> maps = [AddMaps.Level1(), AddMaps.Level2(), AddMaps.Level3(), AddMaps.Level4()];
            Player player = new Player("Player");

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    if (playAgain)
                    {
                        player = NewPlayer();
                        maps = NewMaps();
                        Console.SetCursorPosition(46, 15);
                        Console.WriteLine("Whats your name?");
                        Console.SetCursorPosition(65, 15);
                        player.Name = Console.ReadLine();
                        PlayGame(player, maps, out playAgain);
                        break;
                    }
                    else
                    {
                        Console.SetCursorPosition(46, 15);
                        Console.WriteLine("Whats your name?");
                        Console.SetCursorPosition(65, 15);
                        player.Name = Console.ReadLine();
                        PlayGame(player, maps, out playAgain);
                        break;
                    }

                case ConsoleKey.D2: // GREJER FÖR ATT LADDA, JSON
                    Highscore.ShowHighscore();
                    Console.ReadKey();
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine("quitting...");
                    inMenu = false;
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Thats not a choice!");
                    break;
            }
        }
    }

    static Player NewPlayer()
    {
        Player newPlayer = new Player("Player");
        return newPlayer;
    }
    static List<Map> NewMaps()
    {
        List<Map> maps = [AddMaps.Level1(), AddMaps.Level2(), AddMaps.Level3(), AddMaps.Level4()];
        return maps;
    }

    static void PlayGame(Player player, List<Map> maps, out bool playAgain)
    {
        bool gameOver = false;
        playAgain = false;

        while (!gameOver)
        {
            Console.CursorVisible = false;
            maps[player.MapLevel].PrintMap(player, maps[player.MapLevel]);
            maps[player.MapLevel].MovePlayer(player, maps[player.MapLevel]);

            if (player.CurrentHp < 1)    //börjar sedan om loop och skriver ut mapp igen, om inte player.CurrentHp är 0, isåfall avslutas loop(GameOver)
            {
                Console.Clear();
                Highscore.AddScore(player);
                var choice = Textures.PrintDeadText();
                if (choice.Key == ConsoleKey.R)
                {
                    playAgain = true;
                    return;
                }
                else if (choice.Key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                }
            }
            if (player.wonGame)
            {
                return;
            }
        }
    }
}
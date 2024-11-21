using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        Textures.PrintFirstScreen();
        Player player = new Player("Player");
        Highscore.LoadHighScore();
        bool inMenu = true;

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

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    List<Map> maps = [AddMaps.Level1(), AddMaps.Level2(), AddMaps.Level3(), AddMaps.Level4()];

                    Console.SetCursorPosition(46, 15);
                    Console.WriteLine("Whats your name?");
                    Console.SetCursorPosition(65, 15);
                    player.Name = Console.ReadLine();
                    PlayGame(player, maps);
                    break;

                case ConsoleKey.D2: // GREJER FÖR ATT LADDA, JSON
                    Highscore.ShowHighscore();
                    Console.ReadKey();
                    break;

                case ConsoleKey.D3:
                    Highscore.AddScore(player);
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

    static void PlayGame(Player player, List<Map> maps)
    {
        bool gameOver = false;

        while (!gameOver)
        {
            Console.CursorVisible = false;
            maps[player.MapLevel].PrintMap(player, maps[player.MapLevel]);
            maps[player.MapLevel].MovePlayer(player, maps[player.MapLevel]);

            if (player.CurrentHp < 1)    //börjar sedan om loop och skriver ut mapp igen, om inte player.CurrentHp är 0, isåfall avslutas loop(GameOver)
            {
                Console.Clear();
                Highscore.AddScore(player);
                Textures.PrintDeadText();
                Console.WriteLine("Vill du avsluta eller börja om? [A]vsluta/[B]örja om");
                var choice = Console.ReadKey(true);
                if (choice.Key == ConsoleKey.B)
                {
                    gameOver = true;
                }
                else if (choice.Key == ConsoleKey.A)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        //Textures.PrintFirstScreen();

        bool inMenu = true;

        while (inMenu)
        {
            // Lägga till funktion att välja med wasd eller upp och ner tangenterna?
            Console.Clear();
            Console.SetCursorPosition(40, 5);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********** MAINMENU **********");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(40, 6);
            Console.Write("        1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("New Game");
            Console.SetCursorPosition(40, 7);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Load Game");
            Console.SetCursorPosition(40, 8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        3. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quit Game");
            Console.SetCursorPosition(40, 9);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******************************");
            Console.ResetColor();
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Player player = new Player("Player");
                    List<Map> maps = [AddMaps.Level1(player), AddMaps.Level2(player), AddMaps.Level3(player)];
                    Console.SetCursorPosition(40, 11);
                    Console.WriteLine("Whats your name?");
                    Console.SetCursorPosition(60, 11);
                    player.Name = Console.ReadLine();
                    PlayGame(player, maps);
                    break;

                case "2": // GREJER FÖR ATT LADDA, JSON

                    break;

                case "3":
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
        int level = 0;

        while (!gameOver)
        {
            
            Console.CursorVisible = false;
            maps[level].PrintMap(player, maps[level]);
            maps[level].MovePlayer(player, maps[level], level, out level);

            if (player.CurrentHp < 1)    //börjar sedan om loop och skriver ut mapp igen, om inte player.CurrentHp är 0, isåfall avslutas loop(GameOver)
            {
                Console.Clear();
                Console.WriteLine("Du dog"); // LÄGG IN EN ANIMATION
                Textures.PrintDeadText();
                Console.ReadKey(true);
                gameOver = true;
            }
        }
    }

}
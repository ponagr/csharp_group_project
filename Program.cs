using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("Player");

        List<Map> maps = [AddMaps.Level1(player), AddMaps.Level2(player), AddMaps.Level3(player)];

        GameLevel.level = 0;

        Console.Clear();
        //Textures.PrintFirstScreen();
       // ShowMainMenu(player);
        //Console.ReadLine();

        while (!gameOver)
        {
            Console.CursorVisible = false;
            if (maps[GameLevel.level] is DarkMap)
            {
                GameLevel.PrintDarkLevel(maps, player);
                GameLevel.MovePlayer(maps, player);
            }
            else
            {
                //GameLevel.PrintGameBoard(maps, player);     //Skriver ut mappen
                GameLevel.MovePlayer(maps, player);  //Inväntar sedan input från användaren, flyttar sedan player baserat på input, 
            }

            if (player.CurrentHp < 1)                                  //börjar sedan om loop och skriver ut mapp igen, om inte player.CurrentHp är 0, isåfall avslutas loop(GameOver)
            {
                Console.Clear();
                Console.WriteLine("Du dog"); // LÄGG IN EN ANIMATION
                Textures.PrintDeadText();
                gameOver = true;
            }
        }
        ShowMainMenu(player);
    }

      static void ShowMainMenu(Player player)
    {
        bool inMenu = true;

        while (inMenu)
        {
            Console.SetCursorPosition(20, 5); // Lägga till funktion att välja med wasd eller upp och ner tangenterna?
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********** MAINMENU **********");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("New Game");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Load Game");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("        3. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quit Game");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******************************");
            Console.ResetColor();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Whats your name?");
                    player.Name = Console.ReadLine();
                    inMenu = false;  // Stänger menyn och börjar spelet
                    break;

                case "2": // GREJER FÖR ATT LADDA, JSON

                    break;

                case "3":
                    Console.WriteLine("quitting...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Thats not a choice!");
                    break;
            }
        }
    }
}
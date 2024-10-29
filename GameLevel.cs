using System.Drawing;
using System.Runtime.InteropServices;

#region MAPS
public static class GameLevel
{
    public static char Player = '@';
    public static char Enemy = '£';
    public static char Boss = 'B';
    public static char Coin = '$';
    public static char Wall = '|';
    public static char Terrain = '_';
    public static char Chest = '#';
    public static bool isOpen = false;
    public static char Trap = '¤';
    public static char Empty = ' ';
    public static char Door = '\\';
    public static char Door2 = '/';
    



    public static char[,] gameLevel1 = new char[,] // GÖRA VAR SIN MAP FÖR ATT DET E KUL :)
    {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
           { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
           { '|', '@', '£', ' ', ' ', ' ', ' ', ' ', '¤', ' ', ' ', '|', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', '_', '|', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', '¤', '|', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '\\' },
           { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '/' },
           { '|', ' ', ' ', '#', '|', '£', '|', '$', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', ' ', ' ', '_', '_', '_', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', '£', ' ', '¤', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', '|', '$', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|' },
           { '|', '_', '_', '_', '_', '£', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
           { '|', ' ', ' ', '#', '|', ' ', '|', '$', ' ', ' ', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
           { '|', '£', '_', '_', '|', ' ', '|', '_', '_', ' ', ' ', ' ', ' ', ' ', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
           { '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '_', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|' },
           { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
    };
    #endregion

    #region MOVEMENT
    public static void MovePlayer(char[,] gameMap, Player player, Enemy enemy)
    {
        int posX = 0;
        int posY = 0;
        Chest chest = new Chest();

        var keyPressed = Console.ReadKey();

        for (int i = 0; i < gameMap.GetLength(0); i++)
        {
            for (int j = 0; j < gameMap.GetLength(1); j++)
            {
                if (gameMap[i, j] == Player)
                {
                    posX = i;
                    posY = j;
                }
            }
        }

        if (keyPressed.Key == ConsoleKey.W)
        {
            if (gameMap[posX - 1, posY] == Empty)
            {
                gameMap[posX - 1, posY] = Player; // Byter plats
                gameMap[posX, posY] = Empty; // Där vi stod blir tom
            }
            else if (gameMap[posX - 1, posY] == Enemy)
            {
                Combat.FightMode(player, enemy);
                if (enemy.CurrentHp <= 0)
                {
                    gameMap[posX - 1, posY] = Empty;
                }
                //Om enemy dör(CurrentHealth == 0), ta bort Enemy från map
                //Lägg till Empty där Enemy fanns
            }
            else if (gameMap[posX - 1, posY] == Coin)
            {
                Random random = new Random();
                player.Gold += random.Next(1,6);
                Console.WriteLine($"+{random} guld");
                gameMap[posX - 1, posY] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX - 1, posY] == Trap)
            {
                player.CurrentHp -= 20;
                Console.WriteLine("Du trampade på en mina");
                gameMap[posX - 1, posY] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX - 1, posY] == Chest)
            {
                // Slumpa items/guld, 1-3 typ
                foreach (Item item in chest.ChestLoot)
                {
                    player.Loot(item);
                }
                Console.ReadKey();
                Console.WriteLine("Du gick på en kista");
                // gameMap[posX - 1, posY]
                // openChestCordinates.Add(posX - 1);
                // openChestCordinates.Add(posY);
                gameMap[posX - 1, posY] = Empty;
            }
            else if (gameMap[posX - 1, posY] == Door || gameMap[posX - 1, posY] == Door2)
            {
                // Loada nästa level
                Console.WriteLine("Du klarade nivån");
            }
            else
            {
                //Spelaren går in i en vägg, kan inte flytta dit
                Console.WriteLine("Du kan inte gå hit");
            }
        }
        if (keyPressed.Key == ConsoleKey.A)
        {
            if (gameMap[posX, posY - 1] == Empty)
            {
                gameMap[posX, posY - 1] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX, posY - 1] == Enemy)
            {
                Combat.FightMode(player, enemy);
                if (enemy.CurrentHp <= 0)
                {
                    gameMap[posX, posY - 1] = Empty;
                }
                //Om enemy dör(CurrentHealth == 0), ta bort Enemy från map
                //Lägg till Empty där Enemy fanns
            }
            else if (gameMap[posX, posY - 1] == Coin)
            {
                Random random = new Random();
                player.Gold += random.Next(1,6);
                Console.WriteLine($"+{random} guld");
                gameMap[posX, posY - 1] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX, posY - 1] == Trap)
            {
                player.CurrentHp -= 20;
                Console.WriteLine("Du trampade på en mina");
                gameMap[posX, posY - 1] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX, posY - 1] == Chest)
            {
                // Slumpa items/guld, 1-3 typ
                //Ta sedan bort kistan och gör platsen till Empty
                foreach (Item item in chest.ChestLoot)
                {
                    player.Loot(item);
                }
                Console.ReadKey();
                Console.WriteLine("Du gick på en kista");
            }
            else if (gameMap[posX, posY - 1] == Door || gameMap[posX, posY - 1] == Door2)
            {
                // Loada nästa level
                Console.WriteLine("Du klarade nivån");
            }
            else
            {
                //Spelaren går in i en vägg, kan inte flytta dit
                Console.WriteLine("Du kan inte gå hit");
            }
        }
        if (keyPressed.Key == ConsoleKey.S)
        {
            if (gameMap[posX + 1, posY] == Empty)
            {
                gameMap[posX + 1, posY] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX + 1, posY] == Enemy)
            {
                Combat.FightMode(player, enemy);
                if (enemy.CurrentHp <= 0)
                {
                    gameMap[posX + 1, posY] = Empty;
                }
            }
            else if (gameMap[posX + 1, posY] == Coin)
            {
                Random random = new Random();
                player.Gold += random.Next(1,6);
                Console.WriteLine($"+{random} guld");
                gameMap[posX + 1, posY] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX + 1, posY] == Trap)
            {
                player.CurrentHp -= 20;
                Console.WriteLine("Du trampade på en mina");
                gameMap[posX + 1, posY] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX + 1, posY] == Chest)
            {
                // Slumpa items/guld, 1-3 typ
                foreach (Item item in chest.ChestLoot)
                {
                    player.Loot(item);
                }
                Console.ReadKey();
                //Ta sedan bort kistan och gör platsen till Empty
                Console.WriteLine("Du gick på en kista");

                gameMap[posX + 1, posY] = Empty;
            }
            else if (gameMap[posX + 1, posY] == Door || gameMap[posX + 1, posY] == Door2)
            {
                // Loada nästa level
                Console.WriteLine("Du klarade nivån");
            }
            else
            {
                //Spelaren går in i en vägg, kan inte flytta dit
                Console.WriteLine("Du kan inte gå hit");
            }
        }
        if (keyPressed.Key == ConsoleKey.D)
        {
            if (gameMap[posX, posY + 1] == Empty)
            {
                gameMap[posX, posY + 1] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX, posY + 1] == Enemy)
            {
                Combat.FightMode(player, enemy);
                if (enemy.CurrentHp <= 0)
                {
                    gameMap[posX, posY + 1] = Empty;
                }
            }
            else if (gameMap[posX, posY + 1] == Coin)
            {
                Random random = new Random();
                player.Gold += random.Next(1,6);
                Console.WriteLine($"+{random} guld");
                gameMap[posX, posY + 1] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX, posY + 1] == Trap)
            {
                player.CurrentHp -= 20;
                Console.WriteLine("Du trampade på en mina");
                gameMap[posX, posY + 1] = Player;
                gameMap[posX, posY] = Empty;
            }
            else if (gameMap[posX, posY + 1] == Chest)
            {
                // Slumpa items/guld, 1-3 typ
                foreach (Item item in chest.ChestLoot)
                {
                    player.Loot(item);
                }
                Console.ReadKey();
                //Ta sedan bort kistan och gör platsen till Empty
                Console.WriteLine("Du gick på en kista");
                gameMap[posX, posY + 1] = Empty;
            }
            else if (gameMap[posX, posY + 1] == Door || gameMap[posX, posY + 1] == Door2)
            {
                // Loada nästa level
                Console.WriteLine("Du klarade nivån");
            }
            else
            {
                //Spelaren går in i en vägg, kan inte flytta dit
                Console.WriteLine("Du kan inte gå hit");
            }
        }
        if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
        {
            Console.Clear();
            player.UI(player);
            player.InventoryInfo();
            Console.ReadKey();
        }
    }
    #endregion

    #region PRINTGAMEBOARD
    public static void PrintGameBoard(char[,] gameMap, Player player)  //Tar in och skriver ut den leveln som skickas in till metoden
    {
        //Metodanrop ska ligga i while loop i annan metod för att uppdatera utskriften varje gång vi gör en input och anropar
        //switch/case
        Console.Clear();
        Console.WriteLine();

        // INFO OM KARTAN 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($" Player: {Player}  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"Enemy: {Enemy}  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Chest: {Chest}  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"Coin: {Coin}  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write($"Trap: {Trap}  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Boss: {Boss}  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Door: {Door}  ");
        Console.ResetColor();

        Console.WriteLine();

        // // SKRIVER UT MAP
        for (int i = 0; i < gameMap.GetLength(0); i++)
        {

            for (int j = 0; j < gameMap.GetLength(1); j++)
            {
                if (gameMap[i, j] == Player)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Enemy)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Chest && !isOpen)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Chest && isOpen)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Trap)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Boss)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Coin)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Wall || gameMap[i, j] == Terrain)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Write("   ");
                    Console.ResetColor();
                }
                else if (gameMap[i, j] == Door || gameMap[i, j] == Door2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(gameMap[i, j] + "  ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(gameMap[i, j] + "  ");
                }
            }
            Console.WriteLine();
        }

        player.UI(player);
        // Console.WriteLine();
        // int curretLine = Console.CursorTop;
        // HealthBar.PrintPlayerHealthBar(player);
        // player.ShowHp();
        // Console.SetCursorPosition(29, curretLine);
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine($"Coins: {player.Gold}");
        // Console.SetCursorPosition(50, curretLine);
        // Console.ForegroundColor = ConsoleColor.Magenta;
        // player.ShowXp();
        // Console.ResetColor();


    }
    #endregion
}
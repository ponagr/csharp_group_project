using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

#region MAPS
public static class GameLevel
{
    private static char Player = '@';
    private static char Enemy = '£';
    private static char Boss = 'B';
    private static char Coin = '$';
    private static char Wall = '|';
    private static char Terrain = '_';
    private static char Chest = '#';
    private static bool isOpen = false;
    private static char Trap = '¤';
    private static char Empty = ' ';
    private static char Door = '\\';
    private static char Door2 = '/';
    private static char Heart = '\u2665';


    public static char[,] gameLevel1 = new char[,] 
    {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
        { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
        { '|', '@', '£', ' ', ' ', ' ', ' ', ' ', '¤', ' ', ' ', '|', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', '|' },
        { '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '$', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '£', '|', '_', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', '#', ' ', ' ', '\u2665', ' ', ' ', '|', ' ', ' ', '|', '£', ' ', ' ', ' ', ' ', ' ', ' ', '_', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', ' ', '|' },
        { '|', '#', ' ', ' ', ' ', ' ', ' ', '¤', '|', ' ', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '\\' },
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

       public static char[,] gameLevel2 = new char[,] 
    {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      // DISARMA MINOR?!
        { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
        { '|', '@', ' ', ' ', ' ', ' ', ' ', '|', '#', ' ', ' ', '|', '$', '|', '#', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|' },
        { '|', '_', '_', '_', '_', '_', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', '$', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '|', ' ', '|', '_', '_', '_', '|', ' ', ' ', '|', ' ', '|' },
        { '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '|', ' ', '|' },
        { '|', ' ', '|', '#', '|', ' ', '|', ' ', ' ', ' ', '¤', '\\', ' ', '£', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '¤','/', '$', ' ', '£', ' ', ' ', '|', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', '|', ' ', '|', ' ', '|', '_', '_', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '\\', ' ', ' ', ' ', ' ', '|', '£', '|', '_', '_', ' ', '|', ' ', '_', '_', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', '£', '/', ' ', '£', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', '|', '#', ' ', '£', ' ', '|' },
        { '|', '£', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', '|', '$', '|', '$', ' ', ' ', '|', ' ', ' ', '£', ' ', '|' },
        { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', '#', '|', '_', '|', '$', ' ', ' ', '£', '|', ' ', ' ', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', '_', ' ', '|' },
        { '|', ' ', '_', '_', '|', ' ', '|', '_', '_', '_', '_', '_', ' ', ' ', '£', ' ', ' ', ' ', '$', '|', ' ', ' ', '|' },
        { '|', '£', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '_', '|', ' ', '_', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', ' ', '£', '£', '£', '#', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', '|', ' ', ' ', ' ', ' ', ' ', '£', ' ', '|', ' ', '£', '|' },
        { '\\', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', '_', '_', '_', '_', '_', ' ', '|', '_', ' ', '|' },
        { '/', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
        { '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', '$', '|', ' ', ' ', ' ', ' ', '|' },
        { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
    };
    #endregion

    //Metoder för alla olika utfall som kan ske på mappen, anropas via MovePlayer-metod
    //tar in nya positioner för att flytta spelaren och utför specifika händelser baserat på vilken metod som anropas från MovePlayer
    #region ENEMY
    private static void HandleEnemy(Player player, Enemy enemy, char[,] gameMap, int newX, int newY)
    {
        Combat.FightMode(player, enemy);
        if (enemy.CurrentHp <= 0)
        {
            gameMap[newX, newY] = Empty;
        }
    }
    #endregion

    #region GOLD
    private static void HandleGold(Player player, char[,] gameMap, int posX, int posY, int newX, int newY)
    {
        Random random = new Random();
        player.Gold += random.Next(1, 6);
        Console.WriteLine($"+{random} guld");
        gameMap[newX, newY] = Player;
        gameMap[posX, posY] = Empty;
    }
    #endregion

    #region CHEST
    private static void HandleChest(Chest chest,Player player, char[,] gameMap, int newX, int newY)
    {
        player.Loot(chest);
        
        Console.ReadKey(true);
        Console.WriteLine("Du gick på en kista");
        gameMap[newX, newY] = Empty;
    }
    #endregion

    #region HEART
    private static void HandleHeart(Player player, char[,] gameMap, int posX, int posY, int newX, int newY)
    {
        player.HealingPot.Ammount = 5;
        player.CurrentHp = player.TotalHp;
        gameMap[newX, newY] = Player;
        gameMap[posX, posY] = Empty;
    }
    #endregion

    #region TRAP
    private static void HandleTrap(Player player, char[,] gameMap, int posX, int posY, int newX, int newY)
    {
        player.CurrentHp -= 20;
        Console.WriteLine("Du trampade på en mina");
        gameMap[newX, newY] = Player;
        gameMap[posX, posY] = Empty;
    }
    #endregion

    #region MOVEMENT
    public static void MovePlayer(char[,] gameMap, Player player, Enemy enemy)
    {
        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;
        int newX;       //newX,newY är den nya positionen som vi vill förflytta våran player till
        int newY;
        Chest chest = new Chest();
        
        var keyPressed = Console.ReadKey(true);

        for (int i = 0; i < gameMap.GetLength(0); i++)      //hitta positionen för player och ge dessa värden till posX och posY
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
        newX = posX;
        newY = posY;

        //Ger värde till newX och newY baserat på åt vilket håll vi väljer att gå, via WASD
        #region UP
        if (keyPressed.Key == ConsoleKey.W)
        {
            newX = posX - 1;
            newY = posY;
        }
        #endregion

        #region LEFT
        if (keyPressed.Key == ConsoleKey.A)
        {
            newX = posX;
            newY = posY - 1;
        }
        #endregion

        #region Down
        if (keyPressed.Key == ConsoleKey.S)
        {
            newX = posX + 1;
            newY = posY;
        }
        #endregion

        #region Right
        if (keyPressed.Key == ConsoleKey.D)
        {
            newX = posX;
            newY = posY + 1;
        }
        #endregion

        //Anropar metoder baserat på newX och newY positionerna
        #region MOVEMENTACTIONS
        if (gameMap[newX, newY] == Empty)
        {
            gameMap[newX, newY] = Player; // Byter plats
            gameMap[posX, posY] = Empty; // Där vi stod blir tom
        }
        else if (gameMap[newX, newY] == Enemy)
        {
            HandleEnemy(player, enemy, gameMap, newX, newY);
        }
        else if (gameMap[newX, newY] == Coin)
        {
            HandleGold(player, gameMap, posX, posY, newX, newY);
        }
        else if (gameMap[newX, newY] == Trap)
        {
            HandleTrap(player, gameMap, posX, posY, newX, newY);
        }
        else if (gameMap[newX, newY] == Chest)
        {
            HandleChest(chest,player, gameMap, newX, newY);
        }
        else if (gameMap[newX, newY] == Door || gameMap[newX, newY] == Door2)
        {
            // Loada nästa level
            Console.WriteLine("Du klarade nivån");
        }
        else if (gameMap[newX, newY] == Heart)
        {
            HandleHeart(player, gameMap, posX, posY, newX, newY);
        }
        else
        {
            Console.WriteLine("Du kan inte gå hit");
        }
        #endregion

        #region INVENTORY
        if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
        {
            player.OpenInventory(player);
        }
        #endregion  

        #region HEAL
        if (keyPressed.Key == ConsoleKey.Q)
        {
            player.Heal();  //Använder en Health-Potion
        }
        #endregion
    }
    #endregion

    //Skriver ut info ovanför mappen
    private static void MapInfo()
    {
        Console.WriteLine();
        PrintColor.Green($" Player: {Player}  ", "Write");
        PrintColor.Red($"Enemy: {Enemy}  ", "Write");
        PrintColor.DarkYellow($"Chest: {Chest}  ", "Write");
        PrintColor.Yellow($"Coin: {Coin}  ", "Write");
        PrintColor.Gray($"Trap: {Trap}  ", "Write");
        PrintColor.Red($"Boss: {Boss}  ", "Write");
        PrintColor.Green($"Door: {Door}  ", "Write");
        Console.ResetColor();
        Console.WriteLine();
    }

    #region PRINTGAMEBOARD
    public static void PrintGameBoard(char[,] gameMap, Player player)  //Tar in och skriver ut den leveln som skickas in till metoden
    {
        Console.Clear();
        // INFO OM KARTAN
        MapInfo();

        // SKRIVER UT MAP, med olika textfärger baserat på char
        for (int i = 0; i < gameMap.GetLength(0); i++)
        {
            for (int j = 0; j < gameMap.GetLength(1); j++)
            {
                if (gameMap[i, j] == Player)
                    PrintColor.Green($"{gameMap[i, j]}  ", "Write");
                
                else if (gameMap[i, j] == Enemy)
                    PrintColor.Red($"{gameMap[i, j]}  ", "Write");
                
                else if (gameMap[i, j] == Chest && !isOpen)
                    PrintColor.Yellow($"{gameMap[i, j]}  ", "Write");
                
                else if (gameMap[i, j] == Chest && isOpen) // ANVÄNDS INTE ÄN
                    PrintColor.Gray($"{gameMap[i, j]}  ", "Write");
                
                else if (gameMap[i, j] == Trap)
                    PrintColor.Gray($"{gameMap[i, j]}  ", "Write");
                
                else if (gameMap[i, j] == Boss)
                    PrintColor.Red($"{gameMap[i, j]}  ", "Write");
                
                else if (gameMap[i, j] == Coin)
                    PrintColor.DarkYellow($"{gameMap[i, j]}  ", "Write");
                
                else if (gameMap[i, j] == Wall || gameMap[i, j] == Terrain)
                    PrintColor.BackgroundDarkCyan("   ", "Write");
                
                else if (gameMap[i, j] == Door || gameMap[i, j] == Door2)
                    PrintColor.DarkGreen($"{gameMap[i, j]}  ", "Write");
                
                else
                    Console.Write(gameMap[i, j] + "  ");
            }
            Console.WriteLine();
        }
        PlayerUI.UI(player);    //visa UI under mappen
    }
    #endregion
}
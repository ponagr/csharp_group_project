using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class GameLevel // Chars som alla maps består av
{
    private static char Player = '@';
    private static char Enemy = '£';
    private static char Boss = 'B';
    private static char Coin = '$';
    private static char Wall = '|';
    private static char Terrain = '_';
    private static char Chest = '#';
    private static char Trap = '¤';
    private static char Empty = ' ';
    private static char Door = '\\';
    private static char Door2 = '/';
    private static char Heart = '\u2665';
    private static char GoBack = '=';
    private static char Cellar = ')';
    private static char Merchant = 'M';
    private static char OpenChest = '4';
    private static char invisableAssassin = 'a';

    public static int level;    //Avgör vilket index i listan med Maps, (vilken bana vi är på)




    //Metoder för alla olika utfall som kan ske på mappen, anropas via MovePlayer-metod
    //tar in nya positioner för att flytta spelaren och utför specifika händelser baserat på vilken metod som anropas från MovePlayer
    #region ENEMY
    private static void HandleEnemy(Player player, List<Enemy> enemies, char[,] gameMap, int newX, int newY) // När player går på enemy
    {
        Combat.FightMode(player, enemies[0]);
        if (enemies[0].CurrentHp <= 0)
        {
            enemies.RemoveAt(0);
            gameMap[newX, newY] = Empty;
        }
    }
    #endregion
    private static void HandleInvisibleAssassin(Player player, Assassin assassin, char[,] gameMap, int newX, int newY)
    {
        Combat.FightMode(player, assassin);
        if (assassin.CurrentHp <= 0)
        {
            gameMap[newX, newY] = Empty;
        }
    }
    #region BOSS
    private static void HandleBoss(Player player, Enemy boss, char[,] gameMap, int newX, int newY) // När player går på boss
    {
        Combat.FightMode(player, boss);
        if (boss.CurrentHp <= 0)
        {
            gameMap[newX, newY] = Empty;
        }
    }
    #endregion
    #region GOLD
    private static void HandleGold(Player player, char[,] gameMap, int posX, int posY, int newX, int newY) // När player går på guld
    {
        Random random = new Random();
        int goldDrop = random.Next(1, 6);
        player.Gold += goldDrop;
        PrintColor.Yellow($"+{goldDrop} {'\u00A9'}", "WriteLine");

        gameMap[newX, newY] = Player;
        gameMap[posX, posY] = Empty;
    }
    #endregion

    #region CHEST
    private static void HandleChest(List<Chest> chest, Player player, char[,] gameMap, int newX, int newY) // När player går på chest
    {
        player.Loot(chest[0]);
        chest.RemoveAt(0);
        gameMap[newX, newY] = OpenChest;

        Console.ReadKey(true);
    }
    #endregion

    #region MERCHANT
    private static void HandleMerchant(Merchant merchant, Player player) // När player går på merchant
    {
        merchant.Interact(player);
    }
    #endregion

    #region HEART
    private static void HandleHeart(Player player, char[,] gameMap, int posX, int posY, int newX, int newY) // När player går på hjärta
    {
        player.HealingPot.Ammount = 5;
        player.CurrentHp = player.TotalHp;
        gameMap[newX, newY] = Player;
        gameMap[posX, posY] = Empty;
    }
    #endregion

    #region TRAP
    private static void HandleTrap(Player player, char[,] gameMap, int posX, int posY, int newX, int newY) // När player går på mina
    {
        player.CurrentHp -= 20;
        gameMap[newX, newY] = Player;
        gameMap[posX, posY] = Empty;
    }
    #endregion

    #region NEXTLEVEL
    private static void NextLevel() // Går till nästa map i listan av maps
    {
        level++;
        Console.Clear();
        // Loada nästa level
        Console.WriteLine("Du klarade nivån");
        Textures.PrintLoading();
    }
    #endregion

    #region GOBACK
    private static void PreviousLevel() // Går till förgående map i listan av maps
    {
        level--;
        Console.Clear();
        // Loada nästa level
        Console.WriteLine("Du gick tillbaka en nivå");
        Textures.PrintLoading();
    }
    #endregion

    #region CELLAR
    private static void GoToCellar(Map map, Player player) // Går till källare och träffa merchant mm
    {
        char[,] gameMap = map.CellarLevel;
        List<Enemy> enemies = map.Enemies;
        List<Chest> chests = map.Chests;
        Merchant? merchant = map.Merchant;

        MovePlayer(gameMap, merchant, enemies, chests, player);
    }

    #region EMPTY
    private static void HandleEmpty(char[,] gameMap, int posX, int posY, int newX, int newY)
    {
        gameMap[newX, newY] = Player; // Byter plats
        gameMap[posX, posY] = Empty; // Där vi stod blir tom
    }
    #endregion

    #region MOVE PLAYER
    private static void UpdatePlayerMovement(int posX, int posY, int newX, int newY)
    {
        Console.SetCursorPosition(posY * 3, posX + 2); // Töm den gamla positionen
        Console.Write("  "); // Antag att symbolerna är enkla, annars justera bredden

        Console.SetCursorPosition(newY * 3, newX + 2); // Skriv ut den nya positionen
        PrintColor.Green(" @", "Write");
    }
    #endregion


    #region MOVEMENT
    public static void MovePlayer(List<Map> map, Player player)
    {

        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;
        int newX;       //newX,newY är den nya positionen som vi vill förflytta våran player till
        int newY;

        Console.CursorVisible = false;

        Merchant? merchant = map[level].Merchant;    //Hämtar merchant, enemylista, chestlista, gameMap och boss via Map-objektet
        char[,] gameMap = map[level].Maplevel;
        List<Enemy> enemies = map[level].Enemies;
        Enemy boss = map[level].Boss;
        List<Chest> chests = map[level].Chests;
        Assassin assassin = map[level].Assassin;

        while (player.CurrentHp > 0)
        {
            //Clearar raderna för utskrift om loot
            Console.SetCursorPosition(0, 28);
            Console.WriteLine("                                                                                 ");
            Console.SetCursorPosition(0, 29);
            Console.WriteLine("                                                                                 ");
            Console.SetCursorPosition(0, 30);
            Console.WriteLine("                                                                                 ");
            Console.SetCursorPosition(0, 31);
            Console.WriteLine("                                                                                 ");
            Console.SetCursorPosition(0, 32);
            Console.WriteLine("                                                                                 ");
            Console.SetCursorPosition(0, 33);
            Console.WriteLine("                                                                                 ");

            Console.CursorVisible = false;
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
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleEmpty(gameMap, posX, posY, newX, newY);
            }
            else if (gameMap[newX, newY] == Enemy)
            {
                HandleEnemy(player, enemies, gameMap, newX, newY);
                return;
            }
            else if (gameMap[newX, newY] == Coin)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                Console.SetCursorPosition(0, 29);
                HandleGold(player, gameMap, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            else if (gameMap[newX, newY] == Trap)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleTrap(player, gameMap, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            else if (gameMap[newX, newY] == Chest)
            {
                Console.SetCursorPosition(newY * 3, newX + 2); // Skriv ut den nya positionen
                PrintColor.Gray(" #", "Write");
                Console.SetCursorPosition(0, 29);
                HandleChest(chests, player, gameMap, newX, newY);
            }
            else if (gameMap[newX, newY] == Heart)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleHeart(player, gameMap, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            else if (gameMap[newX, newY] == Boss)
            {
                HandleBoss(player, boss, gameMap, newX, newY);
                return;
            }
            else if (gameMap[newX, newY] == Merchant)
            {
                HandleMerchant(merchant, player);
                return;
            }
            else if (gameMap[newX, newY] == Door || gameMap[newX, newY] == Door2)
            {
                NextLevel();
                break;
            }
            else if (gameMap[newX, newY] == GoBack)
            {
                PreviousLevel();
                break;
            }
            else if (gameMap[newX, newY] == invisableAssassin)
            {
                HandleInvisibleAssassin(player, assassin, gameMap, newX, newY);
                return;
            }
            else if (gameMap[newX, newY] == Cellar)
            {
                GoToCellar(map[level], player);
                break;
            }
            else // Väggar och terräng
            {
                //Gör ingenting
            }
            #endregion

            #region INVENTORY
            if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
            {
                player.OpenInventory(player);
                return;
                //PrintGameBoard(map, player);
            }
            #endregion

            #region HEAL
            if (keyPressed.Key == ConsoleKey.Q) //Använder Health-Potions
            {
                player.Heal();
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            #endregion
            Console.SetCursorPosition(0, 27);
        }
    }
    #endregion

    private static void MapInfo() //Skriver ut info ovanför mappen
    {
        Console.WriteLine();
        PrintColor.Green($" Player: {Player}  ", "Write");
        PrintColor.Red($"Enemy: {Enemy}  ", "Write");
        PrintColor.DarkYellow($"Chest: {Chest}  ", "Write");
        PrintColor.Yellow($"Coin: {'\u00A9'}  ", "Write");
        PrintColor.Gray($"Trap: {Trap}  ", "Write");
        PrintColor.Red($"Boss: {Boss}  ", "Write");
        PrintColor.Green($"Door: {Door}  ", "Write");
        Console.ResetColor();
        Console.WriteLine();
    }

    #region PRINTGAMEBOARD
    public static void PrintGameBoard(List<Map> map, Player player)  //Tar in och skriver ut den mapleveln som skickas in till metoden
    {
        Console.Clear();

        MapInfo(); // INFO OM KARTAN
        Console.CursorVisible = false;
        char[,] gameMap = map[level].Maplevel;

        // SKRIVER UT MAP, med olika textfärger baserat på char
        for (int i = 0; i < gameMap.GetLength(0); i++)
        {
            for (int j = 0; j < gameMap.GetLength(1); j++)
            {
                if (gameMap[i, j] == Player)
                    PrintColor.Green($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == Enemy)
                    PrintColor.Red($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == invisableAssassin)
                    PrintColor.Red($"   ", "Write");

                else if (gameMap[i, j] == Chest)
                    PrintColor.Yellow($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == OpenChest)
                    PrintColor.Gray(" # ", "Write");

                else if (gameMap[i, j] == Merchant)
                    PrintColor.Yellow(" M ", "Write");

                else if (gameMap[i, j] == Trap)
                    PrintColor.Gray($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == Boss)
                    PrintColor.Red($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == Coin)
                    PrintColor.DarkYellow($" {'\u00A9'} ", "Write");

                else if (gameMap[i, j] == Wall || gameMap[i, j] == Terrain)
                    PrintColor.BackgroundDarkCyan("   ", "Write");

                else if (gameMap[i, j] == Door || gameMap[i, j] == Door2)
                    PrintColor.DarkGreen($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == GoBack)
                    PrintColor.BackgroundGreen($" {gameMap[i, j]} ", "Write");
                else if (gameMap[i, j] == Cellar)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write($" {gameMap[i, j]} ");
                    Console.ResetColor();
                }
                else
                    Console.Write($" {gameMap[i, j]} ");
            }
            Console.WriteLine();
        }
        PlayerUI.UI(player);    //visa UI under mappen
    }
    #endregion







    #region CELLARLEVEL
    public static void PrintGameBoard(char[,] gameMap, Player player)  //Tar in och skriver ut den leveln som skickas in till metoden
    {
        Console.Clear();
        // INFO OM KARTAN
        MapInfo();
        Console.CursorVisible = false;

        // SKRIVER UT MAP, med olika textfärger baserat på char
        for (int i = 0; i < gameMap.GetLength(0); i++)
        {
            for (int j = 0; j < gameMap.GetLength(1); j++)
            {
                if (gameMap[i, j] == Player)
                    PrintColor.Green($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == Enemy)
                    PrintColor.Red($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == invisableAssassin)
                    PrintColor.Red($"   ", "Write");

                else if (gameMap[i, j] == Chest)
                    PrintColor.Yellow($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == OpenChest) // ANVÄNDS INTE ÄN
                    PrintColor.Gray(" # ", "Write");

                else if (gameMap[i, j] == Merchant)
                    PrintColor.Yellow(" M ", "Write");

                else if (gameMap[i, j] == Trap)
                    PrintColor.Gray($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == Boss)
                    PrintColor.Red($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == Coin)
                    PrintColor.DarkYellow($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == Wall || gameMap[i, j] == Terrain)
                    PrintColor.BackgroundDarkCyan("   ", "Write");

                else if (gameMap[i, j] == Door || gameMap[i, j] == Door2)
                    PrintColor.DarkGreen($" {gameMap[i, j]} ", "Write");

                else if (gameMap[i, j] == GoBack)
                    PrintColor.BackgroundGreen($" {gameMap[i, j]} ", "Write");
                else if (gameMap[i, j] == Cellar)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write($" {gameMap[i, j]} ");
                    Console.ResetColor();
                }
                else
                    Console.Write(gameMap[i, j] + "  ");
            }
            Console.WriteLine();
        }
        PlayerUI.UI(player);    //visa UI under mappen
    }

    #region CELLARMOVEMENT
    public static void MovePlayer(char[,] gameMap, Merchant merchant, List<Enemy> enemies, List<Chest> chests, Player player) // Players rörelse på banan, wasd osv.
    {
        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;
        int newX;       //newX,newY är den nya positionen som vi vill förflytta våran player till
        int newY;
        bool inCellar = true;
        Console.CursorVisible = false;

        PrintGameBoard(gameMap, player);
        while (inCellar && player.CurrentHp > 0)
        {
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
            #endregion

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
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleEmpty(gameMap, posX, posY, newX, newY);
            }
            else if (gameMap[newX, newY] == Enemy)
            {
                HandleEnemy(player, enemies, gameMap, newX, newY);
                PrintGameBoard(gameMap, player);
            }
            else if (gameMap[newX, newY] == Coin)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                Console.SetCursorPosition(0, 13);
                HandleGold(player, gameMap, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 9);
                PlayerUI.UI(player);
            }
            else if (gameMap[newX, newY] == Trap)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleTrap(player, gameMap, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 9);
                PlayerUI.UI(player);
            }
            else if (gameMap[newX, newY] == Chest)
            {
                Console.SetCursorPosition(newY * 3, newX + 2); // Skriv ut den nya positionen
                PrintColor.Gray(" #", "Write");
                Console.SetCursorPosition(0, 13);
                HandleChest(chests, player, gameMap, newX, newY);
            }
            else if (gameMap[newX, newY] == Merchant)
            {
                HandleMerchant(merchant, player);
                PrintGameBoard(gameMap, player);
            }
            else if (gameMap[newX, newY] == Heart)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleHeart(player, gameMap, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 9);
                PlayerUI.UI(player);
            }
            else if (gameMap[newX, newY] == Cellar)
            {
                inCellar = false;
                return;
            }
            else
            {

            }
            #endregion

            #region INVENTORY
            if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
            {
                player.OpenInventory(player);
                PrintGameBoard(gameMap, player);
            }
            #endregion

            #region HEAL
            if (keyPressed.Key == ConsoleKey.Q)
            {
                player.Heal();  //Använder en Health-Potion
                PlayerUI.UI(player);
            }
            #endregion
        }
    }
    #endregion

    #region DARKLEVEL
    public static void PrintDarkLevel(List<Map> map, Player player)  //Skriver ut mapp med dålig sikt
    {
        Console.Clear();
        char[,] gameMap = map[level].Maplevel;
        // INFO OM KARTAN
        MapInfo();
        Console.CursorVisible = false;
        // SKRIVER UT MAP, med olika textfärger baserat på char

        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;

        Console.WriteLine();
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

        for (int i = posX - 4; i < posX + 4; i++)
        {
            if (i >= 0 && i < gameMap.GetLength(0))
            {
                for (int j = posY - 4; j < posY + 4; j++)
                {
                    if (j >= 0 && j < gameMap.GetLength(1))
                    {
                        if (gameMap[i, j] == Player)
                            PrintColor.Green($" {gameMap[i, j]} ", "Write");

                        else if (gameMap[i, j] == Enemy)
                            PrintColor.Red($" {gameMap[i, j]} ", "Write");

                        else if (gameMap[i, j] == Chest)
                            PrintColor.Yellow($" {gameMap[i, j]} ", "Write");

                        else if (gameMap[i, j] == OpenChest) // ANVÄNDS INTE ÄN
                            PrintColor.Gray($" # ", "Write");

                        else if (gameMap[i, j] == Trap)
                            PrintColor.Gray($" {gameMap[i, j]} ", "Write");

                        else if (gameMap[i, j] == Boss)
                            PrintColor.Red($" {gameMap[i, j]} ", "Write");

                        else if (gameMap[i, j] == Merchant)
                            PrintColor.Yellow(" M ", "Write");

                        else if (gameMap[i, j] == Coin)
                            PrintColor.DarkYellow($" {gameMap[i, j]} ", "Write");

                        else if (gameMap[i, j] == Wall || gameMap[i, j] == Terrain)
                            PrintColor.BackgroundDarkGray("   ", "Write");

                        else if (gameMap[i, j] == Door || gameMap[i, j] == Door2)
                            PrintColor.DarkGreen($" {gameMap[i, j]} ", "Write");

                        else if (gameMap[i, j] == GoBack)
                            PrintColor.BackgroundGreen($" {gameMap[i, j]} ", "Write");
                        else if (gameMap[i, j] == Cellar)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.Write($" {gameMap[i, j]} ");
                            Console.ResetColor();
                        }
                        else
                            Console.Write(gameMap[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    #endregion
    public static void MovePlayerDarkMap(List<Map> map, Player player)
    {

        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;
        int newX;       //newX,newY är den nya positionen som vi vill förflytta våran player till
        int newY;

        Console.CursorVisible = false;

        Merchant? merchant = map[level].Merchant;    //Hämtar merchant, enemylista, chestlista, gameMap och boss via Map-objektet
        char[,] gameMap = map[level].Maplevel;
        List<Enemy> enemies = map[level].Enemies;
        Enemy boss = map[level].Boss;
        List<Chest> chests = map[level].Chests;
        Assassin assassin = map[level].Assassin;

        Console.CursorVisible = false;
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
            HandleEmpty(gameMap, posX, posY, newX, newY);
        }
        else if (gameMap[newX, newY] == Enemy)
        {
            HandleEnemy(player, enemies, gameMap, newX, newY);
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
            HandleChest(chests, player, gameMap, newX, newY);
        }
        else if (gameMap[newX, newY] == Heart)
        {
            HandleHeart(player, gameMap, posX, posY, newX, newY);
        }
        else if (gameMap[newX, newY] == Boss)
        {
            HandleBoss(player, boss, gameMap, newX, newY);
        }
        else if (gameMap[newX, newY] == Merchant)
        {
            HandleMerchant(merchant, player);
        }
        else if (gameMap[newX, newY] == Door || gameMap[newX, newY] == Door2)
        {
            NextLevel();
        }
        else if (gameMap[newX, newY] == GoBack)
        {
            PreviousLevel();
        }
        else if (gameMap[newX, newY] == invisableAssassin)
        {
            HandleInvisibleAssassin(player, assassin, gameMap, newX, newY);
        }
        else if (gameMap[newX, newY] == Cellar)
        {
            GoToCellar(map[level], player);
        }
        else // Väggar och terräng
        {
            //Gör ingenting
        }
        #endregion

        #region INVENTORY
        if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
        {
            player.OpenInventory(player);
        }
        #endregion

        #region HEAL
        if (keyPressed.Key == ConsoleKey.Q) //Använder Health-Potions
        {
            player.Heal();
        }
        #endregion

    }
}
#endregion
using System.ComponentModel.Design;

public abstract class Map
{
    //EN MAP, innehåller massa olika fiender och items osv specifikt för mappen
    public char[,] Maplevel { get; set; }
    public char[,] CellarLevel { get; set; }
    public Merchant? MerchantObject { get; set; }
    public Assassin? Assassin { get; set; }
    public List<Enemy> Enemies { get; set; }
    public List<Chest> Chests { get; set; }
    public Enemy BossEnemy { get; set; }

    internal bool showHelp = false;
    internal static char Player = '@';
    internal static char Enemy = '£';
    internal static char Boss = 'B';
    internal static char Coin = '$';
    internal static char Wall = '|';
    internal static char Terrain = '_';
    internal static char Chest = '#';
    internal static char Trap = '¤';
    internal static char Empty = ' ';
    internal static char Door = '\\';
    internal static char Door2 = '/';
    internal static char Heart = 'H';
    internal static char GoBack = '=';
    internal static char Cellar = ')';
    internal static char Merchant = 'M';
    internal static char OpenChest = '4';
    internal static char invisableAssassin = 'a';

    #region ENEMY 
    // Borde vi inte kunna ha en gemensam metod för enemy, inv assassin och boss??
    internal static void HandleEnemy(Player player, List<Enemy> enemies, char[,] gameMap, int newX, int newY) // När player går på enemy 
    {
        Combat.FightMode(player, enemies[0]);
        if (enemies[0].CurrentHp < 1)
        {
            enemies.RemoveAt(0);
            gameMap[newX, newY] = Empty;
        }
    }
    #endregion
    #region ASSASSIN
    internal static void HandleInvisibleAssassin(Player player, Assassin assassin, char[,] gameMap, int newX, int newY)
    {
        Console.SetCursorPosition(0, 29);
        Console.WriteLine("An invisable assassin shows up!");
        Thread.Sleep(2000);
        Console.ReadKey();
        Combat.FightMode(player, assassin);
        if (assassin.CurrentHp < 1)
        {
            gameMap[newX, newY] = Empty;
        }
    }
    #endregion
    #region BOSS
    internal static void HandleBoss(Player player, Enemy boss, char[,] gameMap, int newX, int newY) // När player går på boss
    {
        Combat.FightMode(player, boss);
        if (boss.CurrentHp < 1)
        {
            gameMap[newX, newY] = Empty;
        }
    }
    #endregion
    #region GOLD
    internal static void HandleGold(Player player, char[,] gameMap, int posX, int posY, int newX, int newY) // När player går på guld
    {
        Random random = new Random();
        int goldDrop = random.Next(1, 6);
        player.Gold += goldDrop;
        PrintColor.Yellow($"+{goldDrop} {'\u00A9'}", "WriteLine");

        HandleEmpty(gameMap, posX, posY, newX, newY);
    }
    #endregion

    #region CHEST
    internal static void HandleChest(List<Chest> chest, Player player, char[,] gameMap, int newX, int newY) // När player går på chest
    {
        player.Loot(chest[0]);
        chest.RemoveAt(0);
        gameMap[newX, newY] = OpenChest;

        Console.ReadKey(true);
    }
    #endregion

    #region MERCHANT
    internal static void HandleMerchant(Merchant merchant, Player player) // När player går på merchant
    {
        merchant.Interact(player);
    }
    #endregion

    #region HEART
    internal static void HandleHeart(Player player, char[,] gameMap, int posX, int posY, int newX, int newY) // När player går på hjärta
    {
        player.HealingPot.Ammount = 5;
        player.CurrentHp = player.TotalHp;
        HandleEmpty(gameMap, posX, posY, newX, newY);
    }
    #endregion

    #region TRAP
    internal static void HandleTrap(Player player, char[,] gameMap, int posX, int posY, int newX, int newY) // När player går på mina
    {
        player.CurrentHp -= 20;
        HandleEmpty(gameMap, posX, posY, newX, newY);
    }
    #endregion

    #region NEXTLEVEL
    internal static void NextLevel(Player player) // Går till nästa map i listan av maps
    {
        Console.Clear();
        player.MapLevel++;
        Console.WriteLine("Du klarade nivån");
        Textures.PrintLoading();
    }
    #endregion

    #region GOBACK
    internal static void PreviousLevel(Player player) // Går till förgående map i listan av maps
    {
        Console.Clear();
        player.MapLevel--;
        Console.WriteLine("Du gick tillbaka en nivå");
        Textures.PrintLoading();
    }
    #endregion

    #region EMPTY
    internal static void HandleEmpty(char[,] gameMap, int posX, int posY, int newX, int newY)
    {
        gameMap[newX, newY] = Player; // Byter plats
        gameMap[posX, posY] = Empty; // Där vi stod blir tom
    }
    #endregion

    #region CURSORPOSITION
    internal static void UpdatePlayerMovement(int posX, int posY, int newX, int newY) // Setcursorpos-metod för att endast uppdatera två platser i konsolen 
    {
        Console.SetCursorPosition(posY * 3, posX + 2); // Töm den gamla positionen
        Console.Write("  "); // Antag att symbolerna är enkla, annars justera bredden

        Console.SetCursorPosition(newY * 3, newX + 2); // Skriv ut den nya positionen
        PrintColor.Green(" @", "Write");
    }
    #endregion

    #region HELP
    public static void Help()   //Hjälptext, som kan togglas på och av med H
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.SetCursorPosition(71, 2);
        Console.WriteLine("H - BACK  ");
        Console.SetCursorPosition(71, 4);
        Console.WriteLine("W - UP");
        Console.SetCursorPosition(71, 5);
        Console.WriteLine("A - LEFT");
        Console.SetCursorPosition(71, 6);
        Console.WriteLine("S - DOWN");
        Console.SetCursorPosition(71, 7);
        Console.WriteLine("D - RIGHT");
        Console.SetCursorPosition(71, 8);
        Console.WriteLine("");
        Console.SetCursorPosition(71, 9);
        Console.WriteLine("C - INVENTORY");
        Console.SetCursorPosition(71, 10);
        Console.WriteLine("Q - HEAL");

        Console.SetCursorPosition(71, 12);
        Console.WriteLine("ESC - MENY");
        Console.ResetColor();
    }
    #endregion

    //Göra override om vi vill anpassa beroende på typ av level?
    #region MAPINFO
    internal static void MapInfo() //Skriver ut info ovanför mappen
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
    #endregion

    public virtual void MovePlayer(Player player, Map map)
    {
        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;
        int newX;       //newX,newY är den nya positionen som vi vill förflytta våran player till
        int newY;

        Console.CursorVisible = false;

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

            for (int i = 0; i < Maplevel.GetLength(0); i++)      //hitta positionen för player och ge dessa värden till posX och posY
            {
                for (int j = 0; j < Maplevel.GetLength(1); j++)
                {
                    if (Maplevel[i, j] == Player)
                    {
                        posX = i;
                        posY = j;
                    }
                }
            }
            newX = posX;
            newY = posY;

            //Ger värde till newX och newY baserat på åt vilket håll vi väljer att gå, via WASD
            if (keyPressed.Key == ConsoleKey.W)
                newX--;
            if (keyPressed.Key == ConsoleKey.A)
                newY--;
            if (keyPressed.Key == ConsoleKey.S)
                newX++;
            if (keyPressed.Key == ConsoleKey.D)
                newY++;


            //Anropar metoder baserat på newX och newY positionerna
            #region MOVEMENTACTIONS
            if (Maplevel[newX, newY] == Empty)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleEmpty(Maplevel, posX, posY, newX, newY);
            }
            else if (Maplevel[newX, newY] == Enemy)
            {
                HandleEnemy(player, Enemies, Maplevel, newX, newY);
                return; // Tillbaka till while-loopen i program.cs
            }
            else if (Maplevel[newX, newY] == Coin)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                Console.SetCursorPosition(0, 29);
                HandleGold(player, Maplevel, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            else if (Maplevel[newX, newY] == Trap)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleTrap(player, Maplevel, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            else if (Maplevel[newX, newY] == Chest)
            {
                Console.SetCursorPosition(newY * 3, newX + 2); // Skriv ut den nya positionen
                PrintColor.Gray(" #", "Write");
                Console.SetCursorPosition(0, 29);
                HandleChest(Chests, player, Maplevel, newX, newY);
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            else if (Maplevel[newX, newY] == Heart)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleHeart(player, Maplevel, posX, posY, newX, newY);
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            else if (Maplevel[newX, newY] == Boss)
            {
                HandleBoss(player, BossEnemy, Maplevel, newX, newY);
                if (BossEnemy.CurrentHp < 1)
                {
                    Maplevel[1, 15] = Empty;
                    Maplevel[2, 15] = Empty;
                }
                return;
            }
            else if (Maplevel[newX, newY] == Merchant)
            {
                HandleMerchant(MerchantObject, player);
                return;
            }
            else if (Maplevel[newX, newY] == Door || Maplevel[newX, newY] == Door2)
            {
                NextLevel(player);
                break;
            }
            else if (Maplevel[newX, newY] == GoBack)
            {
                PreviousLevel(player);
                break;
            }
            else if (Maplevel[newX, newY] == invisableAssassin)
            {
                HandleInvisibleAssassin(player, Assassin, Maplevel, newX, newY);
                return;
            }
            else // Väggar och terräng
            {
                //Gör ingenting
            }
            #endregion

            if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
            {
                player.OpenInventory(player);  
                return;
            }
            if (keyPressed.Key == ConsoleKey.Q) //Använder Health-Potions
            {
                player.Heal();
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            if (keyPressed.Key == ConsoleKey.H)
            {
                
                if(showHelp == false)
                {
                    Help();
                    showHelp = true;
                }
                else
                {
                    PlayerUI.HelpText();
                    showHelp = false;
                }
            }
            Console.SetCursorPosition(0, 27);
        }
    }

    #region PRINT MAP
    public virtual void PrintMap(Player player, Map map)
    {
        Console.Clear();

        MapInfo(); // INFO OM KARTAN
        Console.CursorVisible = false;
        char[,] gameMap = Maplevel;

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
                else if (gameMap[i, j] == Heart)
                    PrintColor.DarkRed($" {'\u2665'} ", "Write");
                else
                    Console.Write($" {gameMap[i, j]} ");
            }
            Console.WriteLine();
        }
        PlayerUI.UI(player);    //visa UI under mappen
    }
    #endregion
}

public class RegularMap : Map
{
    public RegularMap(char[,] map, List<Enemy> enemies, Assassin assassin, List<Chest> chests, Enemy boss, Merchant merchant)
    {
        Maplevel = map;
        Enemies = enemies;
        Chests = chests;
        BossEnemy = boss;
        MerchantObject = merchant;
        Assassin = assassin;
    }
}


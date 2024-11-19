public class CellarMap : Map
{
    public CellarMap(char[,] map, char[,] cellarMap, Assassin assassin, List<Enemy> enemies, List<Chest> chests, Enemy boss, Merchant merchant)
    {
        Maplevel = map;
        CellarLevel = cellarMap;
        Enemies = enemies;
        Chests = chests;
        BossEnemy = boss;
        MerchantObject = merchant;
        Assassin = assassin;
    }

    public override void MovePlayer(Player player, Map map)
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
                return;
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
                    Maplevel[11, 9] = Empty;
                }
                return;
            }
            else if (Maplevel[newX, newY] == Merchant)
            {
                HandleMerchant(MerchantObject, player);
                return;
            }
            else if (Maplevel[newX, newY] == Cellar)
            {
                CellarMovement(map, player);
                break;
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

            if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
            {
                player.OpenInventory(player);
                return;
                //PrintGameBoard(map, player);
            }
            if (keyPressed.Key == ConsoleKey.Q) //Använder Health-Potions
            {
                player.Heal();
                Console.SetCursorPosition(0, 25);
                PlayerUI.UI(player);
            }
            if (keyPressed.Key == ConsoleKey.H)
            {

                if (showHelp == false)
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
        #endregion

    }
    #region PRINTCELLAR
    public static void PrintCellar(char[,] gameMap, Player player)
    {
        Console.Clear();

        MapInfo(); // INFO OM KARTAN
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

    #region CELLARMOVEMENT
    public static void CellarMovement(Map cellarMap, Player player) // Players rörelse på banan, wasd osv.
    {
        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;
        int newX;       //newX,newY är den nya positionen som vi vill förflytta våran player till
        int newY;
        bool inCellar = true;
        Console.CursorVisible = false;

        char[,] gameMap = cellarMap.CellarLevel; // skapar en referens till Map-objektsts CellarLevel(2D char[]-array)
        Merchant merchant = cellarMap.MerchantObject;
        List<Enemy> enemies = cellarMap.Enemies;
        List<Chest> chests = cellarMap.Chests;

        PrintCellar(gameMap, player);
        while (inCellar && player.CurrentHp > 0)
        {
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

            var keyPressed = Console.ReadKey(true);

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
            if (gameMap[newX, newY] == Empty)
            {
                UpdatePlayerMovement(posX, posY, newX, newY);
                HandleEmpty(gameMap, posX, posY, newX, newY);
            }
            else if (gameMap[newX, newY] == Enemy)
            {
                HandleEnemy(player, enemies, gameMap, newX, newY);
                PrintCellar(gameMap, player);
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
                PrintCellar(gameMap, player);
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
            }
            else // Om vi går in i väggar
            {

            }

            if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
            {
                player.OpenInventory(player);
                PrintCellar(gameMap, player);
            }
            if (keyPressed.Key == ConsoleKey.Q)
            {
                player.Heal();  //Använder en Health-Potion
                PlayerUI.UI(player);
            }
        }
    }
    #endregion
}
public class DarkMap : Map
{
    public DarkMap(char[,] map, List<Enemy> enemies, Assassin assassin, List<Chest> chests, Enemy boss, Merchant merchant)
    {
        Maplevel = map;
        Enemies = enemies;
        Chests = chests;
        BossEnemy = boss;
        MerchantObject = merchant;
        Assassin = assassin;
    }
    
    #region PRINTMAP
    public override void PrintMap(Player player, Map map)
    {
        Console.Clear();
        char[,] gameMap = map.Maplevel;
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

                        else if (gameMap[i, j] == invisableAssassin)
                            PrintColor.Red($"   ", "Write");

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
                        else if (gameMap[i, j] == Heart)
                            PrintColor.DarkRed($" {'\u2665'} ", "Write");
                        else
                            Console.Write(gameMap[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
        PlayerUI.UI(player);
    }
    #endregion

    public override void MovePlayer(Player player, Map map)
    {
        int posX = 0;   //posX,posY är positionen som player har för tillfället
        int posY = 0;
        int newX;       //newX,newY är den nya positionen som vi vill förflytta våran player till
        int newY;

        Console.CursorVisible = false;

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
            HandleEmpty(Maplevel, posX, posY, newX, newY);
        }
        else if (Maplevel[newX, newY] == Enemy)
        {
            HandleEnemy(player, Enemies, Maplevel, newX, newY);
        }
        else if (Maplevel[newX, newY] == Coin)
        {
            HandleGold(player, Maplevel, posX, posY, newX, newY);
        }
        else if (Maplevel[newX, newY] == Trap)
        {
            HandleTrap(player, Maplevel, posX, posY, newX, newY);
        }
        else if (Maplevel[newX, newY] == Chest)
        {
            HandleChest(Chests, player, Maplevel, newX, newY);
        }
        else if (Maplevel[newX, newY] == Heart)
        {
            HandleHeart(player, Maplevel, posX, posY, newX, newY);
        }
        else if (Maplevel[newX, newY] == Boss)
        {
            HandleBoss(player, BossEnemy, Maplevel, newX, newY);
        }
        else if (Maplevel[newX, newY] == Merchant)
        {
            HandleMerchant(MerchantObject, player);
        }
        else if (Maplevel[newX, newY] == Door || Maplevel[newX, newY] == Door2)
        {
            //Textures.PrintCongratz();
            NextLevel(player);
        }
        else if (Maplevel[newX, newY] == GoBack)
        {
            PreviousLevel(player);
        }
        else if (Maplevel[newX, newY] == invisableAssassin)
        {
            HandleInvisibleAssassin(player, Assassin, Maplevel, newX, newY);
        }
        else // Väggar och terräng
        {
            //Gör ingenting
        }
        #endregion

        if (keyPressed.Key == ConsoleKey.C) //Visa playerStats
        {
            player.OpenInventory(player);
        }
        if (keyPressed.Key == ConsoleKey.Q) //Använder Health-Potions
        {
            player.Heal();
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
    }
}
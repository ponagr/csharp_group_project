public class MapWithRooms : Map
{
    public List<Enemy> Enemies1 { get; set; }
    public List<Enemy> Enemies2 { get; set; }
    public List<Enemy> Enemies3 { get; set; }
    public List<Enemy> Enemies4 { get; set; }
    public MapWithRooms(char[,] map, List<Enemy> enemies1, List<Enemy> enemies2, List<Enemy> enemies3, List<Enemy> enemies4, List<Enemy> enemiesBeforeBoss, Assassin assassin, List<Chest> chests, Enemy boss, Merchant merchant)
    {
        Maplevel = map;
        Enemies = enemiesBeforeBoss;
        Enemies1 = enemies1;
        Enemies2 = enemies2;
        Enemies3 = enemies3;
        Enemies4 = enemies4;
        Chests = chests;
        BossEnemy = boss;
        MerchantObject = merchant;
        Assassin = assassin;
    }

    protected void HandleWalls() // Kollar om enemies listorna är tomma - ta isåfall bort en vägg
    {
        if (Enemies1.Count == 0)
        {
            Maplevel[15, 8] = Empty;  
        }
        if (Enemies2.Count == 0)
        {
            Maplevel[11, 1] = Empty;
        }
        if (Enemies3.Count == 0)
        {
            Maplevel[8, 12] = Empty;
            Maplevel[8, 16] = Empty;
        }
        if (Enemies4.Count == 0)
        {
            Maplevel[15, 16] = Empty;
        }
        if (Enemies.Count == 0) // && BossEnemy.CurrentHp == 0 ??
        {
            Maplevel[22, 20] = Door;
        }
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
                List<Enemy> enemies = Enemies1;
                if (Enemies1.Count == 0)
                {
                    enemies = Enemies2;
                }
                if (Enemies2.Count == 0)
                {
                    enemies = Enemies3;
                }
                if (Enemies3.Count == 0)
                {
                    enemies = Enemies4;
                }
                if (Enemies4.Count == 0)
                {
                    enemies = Enemies;
                }
                HandleEnemy(player, enemies, Maplevel, newX, newY);
                HandleWalls();
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
                return;
            }
            else if (Maplevel[newX, newY] == Merchant)
            {
                HandleMerchant(MerchantObject, player);
                return;
            }
            else if (Maplevel[newX, newY] == Door || Maplevel[newX, newY] == Door2)
            {
                Console.Clear();
                Highscore.AddScore(player);
                Textures.PrintCongratz();
                player.wonGame = true;
                return;
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
            if (keyPressed.Key == ConsoleKey.Escape)
            {
                PauseMenu(player);
                return;
            }
            Console.SetCursorPosition(0, 27);
        }
    }
}
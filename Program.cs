class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("Player");
        // List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        // new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        // new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        // Merchant merchant = new Merchant("Merchant", 1000, items);

        //merchant.ShowInventory(player);
        //GameLevel.AllMaps = [AddMaps.Level1(player), AddMaps.Level2(player), AddMaps.Level3(player)];

        //Lös på nått sätt så att vi kan skapa lägga in en ny mapp i listan NÄR vi klarar av en mapp så att enemys skapas och blir starkare baserat på player.Level


        List<Map> maps = [AddMaps.Level1(player), AddMaps.Level2(player), AddMaps.Level3(player)];
        //char Coin = 'u\&#8226';
        GameLevel.level = 0;
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
                GameLevel.PrintGameBoard(maps, player);     //Skriver ut mappen
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
    }
}
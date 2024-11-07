class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("Player");
        Enemy enemy = new Enemy(player);
        List<Item> items = new List<Item>() {new Consumable(), new THelm("Plåthjälm", 5, 30, 20, 0),
        new TWeapon("Gimlis Yxa", "Yxa", 40, 10, 0, 20), new TWeapon("Legolas Pilbåge", "Pilbåge", 30, 15, 5, 15),
        new TBoots("Foppatofflor", 5, 0, 5, -5), new TGloves("Plåthandskar", 5, 30, 20, 5), new TLegs("Läderbyxor", 0, 20, 15, 20) };
        Merchant merchant = new Merchant("Merchant", 1000, items);

        merchant.ShowInventory(player);

        List<Map> maps = [AddMaps.Level1(player), AddMaps.Level2(player), AddMaps.Level3(player)];

        GameLevel.level = 0;
        // while (!gameOver)
        // {
        //     if (maps[GameLevel.level] is DarkMap)
        //     {
        //         GameLevel.PrintDarkLevel(maps, player);
        //         GameLevel.MovePlayer(maps, player);
        //     }
        //     else
        //     {
        //         GameLevel.PrintGameBoard(maps, player);     //Skriver ut mappen
        //         GameLevel.MovePlayer(maps, player);  //Inväntar sedan input från användaren, flyttar sedan player baserat på input, 
        //     }
            
        //     if (player.CurrentHp < 1)                                  //börjar sedan om loop och skriver ut mapp igen, om inte player.CurrentHp är 0, isåfall avslutas loop(GameOver)
        //     {
        //         Console.Clear();
        //         Console.WriteLine("Du dog"); // LÄGG IN EN ANIMATION
        //         Textures.PrintDeadText();
        //         gameOver = true;
        //     }
        // }
    }
}
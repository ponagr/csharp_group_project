class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("Player");

        List<Map> maps = [AddMaps.Level1(player), AddMaps.Level2(player), AddMaps.Level3(player)];

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
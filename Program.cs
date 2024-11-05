class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("Player");
        Enemy enemy = new Enemy(player);
        Assassin assassin = new Assassin(player);
        Butcher butcher = new Butcher(player);
        Archer archer = new Archer(player);

        List<Enemy> enemies = new List<Enemy>();  
        enemies.Add(archer);
        enemies.Add(butcher);
        enemies.Add(assassin);
        enemies.Add(enemy);
        enemies.Add(enemy);
        enemies.Add(enemy);
        enemies.Add(enemy);
        enemies.Add(enemy);
        enemies.Add(enemy);

        Items.ItemsToAdd();     //Lägger till items så att dessa existerar i spelet och kan lootas via kistor
        
        while (!gameOver)
        {
            GameLevel.PrintGameBoard(GameLevel.gameLevel1, player);     //Skriver ut mappen
            GameLevel.MovePlayer(GameLevel.gameLevel1, player, enemies);  //Inväntar sedan input från användaren, flyttar sedan player baserat på input, 
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
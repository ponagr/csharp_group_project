class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("Player");
        Enemy enemy = new Enemy(player);
        Items.ItemsToAdd();     //Lägger till items så att dessa existerar i spelet och kan lootas via kistor
        
        while (!gameOver)
        {
            GameLevel.PrintGameBoard(GameLevel.gameLevel1, player);     //Skriver ut mappen
            GameLevel.MovePlayer(GameLevel.gameLevel1, player, enemy);  //Inväntar sedan input från användaren, flyttar sedan player baserat på input, 
            if (player.CurrentHp <= 0)                                  //börjar sedan om loop och skriver ut mapp igen, om inte player.CurrentHp är 0, isåfall avslutas loop(GameOver)
            {
                Console.WriteLine("Du dog"); // LÄGG IN EN ANIMATION
                gameOver = true;
            }
        }

        
    }
}
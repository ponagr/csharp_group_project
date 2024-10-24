class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("Player");
        Enemy enemy = new Enemy();
        while (!gameOver)
        {
            GameLevel.PrintGameBoard(GameLevel.gameLevel1, player);
            GameLevel.MovePlayer(GameLevel.gameLevel1, player, enemy);
            if (player.CurrentHp <= 0)
            {
                Console.WriteLine("Du dog");
                gameOver = true;
            }
        }

        
    }
}
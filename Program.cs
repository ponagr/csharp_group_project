class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;
        Player player = new Player("player");
        while (!gameOver)
        {
            GameLevel.PrintGameBoard(GameLevel.gameLevel1, player);
            GameLevel.MovePlayer(GameLevel.gameLevel1, player);
            player.ShowHp();
        }
        
    }
}
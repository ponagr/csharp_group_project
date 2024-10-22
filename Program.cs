class Program
{
    static void Main(string[] args)
    {
        bool gameOver = false;

        while (!gameOver)
        {
            GameLevel.PrintGameBoard(GameLevel.gameLevel1);
            GameLevel.MovePlayer(GameLevel.gameLevel1);
        }
        
    }
}
public static class GameLevel
{
    public static char[,] gameLevel1 = new char[,]
    {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23
           { ' ', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
           { '|', ' ', ' ', '¤', '?', ' ', ' ', 'E', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', 'E', '$', '$', ' ', '$', 'E', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', '¤', '¤', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', 'E', ' ', '$', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', '¤', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '\\' },
           { '|', ' ', ' ', ' ', ' ', ' ', '$', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', '$', 'E', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', 'E', '¤', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|', '_', '_', '_', '_', '_', '_', '_', '_', ' ', '_', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
           { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
    };
    public static void PrintGameBoard(char[,] gameMap)  //Tar in och skriver ut den leveln som skickas in till metoden
    {
        //Metodanrop ska ligga i while loop i annan metod för att uppdatera utskriften varje gång vi gör en input och anropar
        //switch/case
        Console.Clear();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Player: '@' ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Enemy: '£' ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Chest: '#' ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Trap: '¤' ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Boss: '$' ");
        Console.ResetColor();

        Console.WriteLine();

        for (int i = 0; i < gameMap.GetLength(0); i++)
        {
            
            for (int j = 0; j < gameMap.GetLength(1); j++)
            {
                if (gameMap[i,j] == '@')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(gameMap[i,j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i,j] == '£')
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(gameMap[i,j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i,j] == '#')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(gameMap[i,j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i,j] == '¤')
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(gameMap[i,j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i,j] == '$')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(gameMap[i,j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i,j] == '|' || gameMap[i,j] == '_')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;             
                    Console.Write(gameMap[i,j] + "  ");
                    Console.ResetColor();
                }
                else if (gameMap[i,j] == '.')
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(gameMap[i,j] + "  ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(gameMap[i,j] + "  ");
                }
                
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
    }
}